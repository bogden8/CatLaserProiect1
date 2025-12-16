using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;//biblioteca pentru usb
using System.Threading;
using System.Threading.Tasks;//sa pot opri executia
using System.Windows.Forms;

namespace CatLaserProiect1
{
    
    public partial class Form1 : Form
    {
        //variabile globale
        SerialPort portArduino;
        List<Miscare> listaDeMiscari = new List<Miscare>();

        //generator de numere random
        Random rng = new Random();

        //variabile de control pt oprire
        bool oprireSolicitata = false;

        public Form1()
        {
            InitializeComponent();
            portArduino = new SerialPort();
        }

        //functia ce trimite comanda la arduino
        private void TrimiteLaArduino(int x, int y)
        {
            if (portArduino.IsOpen)
            {
                string comanda = $"X{x}Y{y}\n";
                portArduino.Write(comanda);
            }
        }

        //functie ce improspateaza lista vizuala
        private void ActualizeazaListaVizuala()
        {
            lstMiscari.Items.Clear();
            foreach (var m in listaDeMiscari)
            {
                lstMiscari.Items.Add(m.ToString());
            }
        }
        //conectare la arduino
        private void btnConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!portArduino.IsOpen)
                {
                    portArduino.PortName = txtPort.Text.Trim();
                    portArduino.BaudRate = 9600;
                    portArduino.Open();
                    MessageBox.Show("Conectat cu succes la Arduino!", "Succes");
                    btnConnect.Text = "Deconectează";
                }
                else
                {
                    portArduino.Close();
                    btnConnect.Text = "Conectare";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la conectare: " + ex.Message + "\nVerifică dacă ai scris corect COM-ul!");
            }
        }

        //slider X
        private void trackBarX_Scroll_1(object sender, EventArgs e)
        {
            TrimiteLaArduino(trackBarX.Value, trackBarY.Value);
        }

        //slider Y
        private void trackBarY_Scroll_1(object sender, EventArgs e)
        {
            TrimiteLaArduino(trackBarX.Value, trackBarY.Value);
        }

        //adaug miscarea in lista
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Miscare miscareNoua = new Miscare(trackBarX.Value, trackBarY.Value);
            listaDeMiscari.Add(miscareNoua);
            ActualizeazaListaVizuala();
        }

        //algoritmul de sortare bubble sort dupa axa X
        private void btnSort_Click_1(object sender, EventArgs e)
        {
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i < listaDeMiscari.Count - 1; i++)
                {
                    if (listaDeMiscari[i].X > listaDeMiscari[i + 1].X)
                    {
                        Miscare temp = listaDeMiscari[i];
                        listaDeMiscari[i] = listaDeMiscari[i + 1];
                        listaDeMiscari[i + 1] = temp;
                        swap = true;
                    }
                }
            } while (swap);

            ActualizeazaListaVizuala();
            MessageBox.Show("Lista a fost sortată după axa X!", "Algoritm Finalizat");
        }

        //salvarae de fisiere
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                //fereastra ce apare cand salvezi
                SaveFileDialog fereastraSalvare = new SaveFileDialog();
                fereastraSalvare.Filter = "Text Files|*.txt";
                fereastraSalvare.Title = "Salvează Mișcările (ex: Sufragerie)";
                fereastraSalvare.FileName = "camera_mea.txt";

                
                if (fereastraSalvare.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(fereastraSalvare.FileName))
                    {
                        foreach (var m in listaDeMiscari)
                        {
                            sw.WriteLine($"{m.X},{m.Y}");
                        }
                    }
                    MessageBox.Show("Fișier salvat: " + Path.GetFileName(fereastraSalvare.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nu am putut salva: " + ex.Message);
            }
        }

        //executarea listei
        private async void btnExecute_Click_1(object sender, EventArgs e)
        {
            if (listaDeMiscari.Count == 0)
            {
                MessageBox.Show("Lista e goală! Adaugă mișcări sau generează Random.");
                return;
            }

            oprireSolicitata = false;
            btnExecute.Enabled = false;

            foreach (var m in listaDeMiscari)
            {
                if (oprireSolicitata == true)
                {
                    MessageBox.Show("Execuție oprită de utilizator!");
                    break;
                }

                lstMiscari.SelectedIndex = listaDeMiscari.IndexOf(m);
                lstMiscari.Update();

                TrimiteLaArduino(m.X, m.Y);
                await Task.Delay(500);
            }

            if (!oprireSolicitata)
            {
                MessageBox.Show("Execuție terminată!");
            }

            btnExecute.Enabled = true;
        }

        //generare miscari random
        private void btnRandom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int randX = rng.Next(90, 170);
                int randY = rng.Next(0, 160);
                listaDeMiscari.Add(new Miscare(randX, randY));
            }
            ActualizeazaListaVizuala();
            MessageBox.Show("Am adăugat 10 mișcări aleatorii!");
        }

        //curatarea listei
        private void btnClear_Click(object sender, EventArgs e)
        {
            listaDeMiscari.Clear();
            ActualizeazaListaVizuala();
            MessageBox.Show("Lista a fost ștearsă!");
        }

        //butonul de stop
        private void btnStop_Click(object sender, EventArgs e)
        {
            oprireSolicitata = true;
        }

        //incarcarea fisierului in programul meu
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fereastraIncarcare = new OpenFileDialog();
                fereastraIncarcare.Filter = "Text Files|*.txt";
                fereastraIncarcare.Title = "Alege fișierul de încărcat";

                if (fereastraIncarcare.ShowDialog() == DialogResult.OK)
                {
                    //citieste dtoate linile din fisier
                    string[] linii = File.ReadAllLines(fereastraIncarcare.FileName);

                    //stergem lista ca sa nu amestecam camerele
                    listaDeMiscari.Clear();

                    foreach (string linie in linii)
                    {
                        string[] parti = linie.Split(',');//spargem virgula
                        if (parti.Length == 2)
                        {
                            int x = int.Parse(parti[0]);
                            int y = int.Parse(parti[1]);
                            listaDeMiscari.Add(new Miscare(x, y));
                        }
                    }
                    ActualizeazaListaVizuala();
                    MessageBox.Show("Am încărcat cu succes: " + Path.GetFileName(fereastraIncarcare.FileName));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citire: " + ex.Message);
            }
        }

        //Functii vechi generate automat ca sa nu mai dea eroare programul
        private void txtPort_TextChanged(object sender, EventArgs e) { }
        private void btnConnect_Click(object sender, EventArgs e) { }
        private void txtPort_TextChanged_1(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

    } 

    
    public class Miscare
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Miscare(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"Pozitie -> X: {X} grad, Y: {Y} grad";
        }
    }
}