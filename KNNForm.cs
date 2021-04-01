using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KNN_Iris
{
    public partial class KNNForm : Form
    {
        string fileiris;
        string fileclas;
        List<double[]> trainingSetValues = new List<double[]>();
        List<string> trainingSetClasses = new List<string>();
        List<double[]> testSetValues = new List<double[]>();
        List<string> testSetClasses = new List<string>();
        private int lines;

        public enum DataType
        {
            TRAININGDATA, TESTDATA
        };

        public KNNForm()
        {
            InitializeComponent();
        }

        private void KNNForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("data/saved classification files");
            Directory.CreateDirectory("data/iris data");
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btn_open_firis, "Открыть файл данных ирисов Фишера");
            toolTip1.SetToolTip(btn_open_fclas, "Открыть файл ирисов для классификации");
            toolTip1.SetToolTip(btn_save_fclas, "Сохранить файл ирисов для классификации");
            toolTip1.SetToolTip(btn_addclas, "Добавить ирис для классификации из данных ирисов Фишера");
            toolTip1.SetToolTip(btn_dgvclas_clear, "Очистить данные ирисов для классификации");
            toolTip1.SetToolTip(btn_dgvclas_rowdel, "Удалить ирис из классификации");
            toolTip1.SetToolTip(btn_link_github, "Ссылка на репозиторий в GitHub");
        }

        private void save_file()
        {
            string namefileclas = DateTime.Now.ToString("d-M-yyyy HH-mm-ss");
            FileStream fs = new FileStream(@"data\saved classification files\" + namefileclas + ".data", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fs);
            for (int j = 0; j < dataGridViewClas.Rows.Count; j++)
            {
                for (int i = 0; i < dataGridViewClas.Rows[j].Cells.Count; i++)
                {
                    streamWriter.Write(dataGridViewClas.Rows[j].Cells[i].Value);
                    if (i != dataGridViewClas.Rows[j].Cells.Count - 1)
                        streamWriter.Write(",");
                }
                streamWriter.WriteLine();
            }
            
            streamWriter.Close();
            fs.Close();
        }

        private void btn_open_firis_Click(object sender, EventArgs e)
        {
            OpenFileDialog cFile = new OpenFileDialog();
            cFile.Filter = "data iris file|*.data";
            cFile.ShowDialog();
            fileiris = cFile.FileName;
            string line;
            int i = 0;
            if (fileiris != "") 
            {
                dataGridViewIris.Rows.Clear();
                StreamReader file = new StreamReader(fileiris);
                while ((line = file.ReadLine()) != null)
                {
                    string[] split = line.Split(',');
                    string[] row = new string[6];
                    i++;
                    row[0] = i.ToString();
                    row[1] = split[0];
                    row[2] = split[1];
                    row[3] = split[2];
                    row[4] = split[3];
                    row[5] = split[4];
                    dataGridViewIris.Rows.Add(row);
                }
                file.Close();
            }
        }

        private void btn_open_fclas_Click(object sender, EventArgs e)
        {
            OpenFileDialog cFile = new OpenFileDialog();
            cFile.Filter = "data iris classification file|*.data";
            cFile.ShowDialog();
            fileclas = cFile.FileName;
            string line;
            if (fileclas != "")
            {
                dataGridViewClas.Rows.Clear();
                StreamReader file = new System.IO.StreamReader(fileclas);
                while ((line = file.ReadLine()) != null)
                {
                    string[] split = line.Split(',');
                    string[] row = new string[5];
                    row[0] = split[0];
                    row[1] = split[1];
                    row[2] = split[2];
                    row[3] = split[3];
                    row[4] = split[4];
                    dataGridViewClas.Rows.Add(row);
                }
                file.Close();
            }
        }

        private void btn_addclas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewIris.SelectedRows.Count; i++)
            {
                int index = dataGridViewClas.Rows.Add();
                dataGridViewClas.Rows[index].Cells[0].Value = dataGridViewIris.SelectedRows[i].Cells[1].Value.ToString();
                dataGridViewClas.Rows[index].Cells[1].Value = dataGridViewIris.SelectedRows[i].Cells[2].Value.ToString();
                dataGridViewClas.Rows[index].Cells[2].Value = dataGridViewIris.SelectedRows[i].Cells[3].Value.ToString();
                dataGridViewClas.Rows[index].Cells[3].Value = dataGridViewIris.SelectedRows[i].Cells[4].Value.ToString();
                dataGridViewClas.Rows[index].Cells[4].Value = dataGridViewIris.SelectedRows[i].Cells[5].Value.ToString();
            }
        }

        private void btn_save_fclas_Click(object sender, EventArgs e)
        {
            save_file();
        }

        private void btn_dgvclas_clear_Click(object sender, EventArgs e)
        {
            dataGridViewClas.Rows.Clear();
        }

        private void btn_dgvclas_rowdel_Click(object sender, EventArgs e)
        {
            dataGridViewClas.Rows.RemoveAt(dataGridViewClas.CurrentRow.Index);
        }

        private void trackBarClas_Scroll(object sender, EventArgs e)
        {
            lbl_numk.Text = trackBarClas.Value.ToString();
        }

        private void btn_clas_Click(object sender, EventArgs e)
        {
            richTextBoxResult.Text = "";
            if (fileclas == "")
            {
                save_file();
            }
            LoadData(fileiris, DataType.TRAININGDATA);
            LoadData(fileclas, DataType.TESTDATA);
            int k = trackBarClas.Value;
            double[][] distances = new double[trainingSetValues.Count][];
            double accuracy = 0;
            double correct = 0, testNumber = 0;
            for (int i = 0; i < trainingSetValues.Count; i++)
                distances[i] = new double[2];
            richTextBoxResult.Text += "\n[i]...Классификация...";
            for (var test = 0; test < this.testSetValues.Count; test++)
            {
                Parallel.For(0, trainingSetValues.Count, index =>
                {
                    var dist = EuclideanDistance(this.testSetValues[test], this.trainingSetValues[index]);
                    distances[index][0] = dist;
                    distances[index][1] = index;
                }
                );
                richTextBoxResult.Text += "\n[+] Ближайщие k=" + k + " соседи:";
                var sortedDistances = distances.AsParallel().OrderBy(t => t[0]).Take(k);
                string realClass = testSetClasses[test];
                foreach (var d in sortedDistances)
                {
                    string predictedClass = trainingSetClasses[(int)d[1]];
                    if (string.Equals(realClass, predictedClass) == true)
                        correct++;
                    testNumber++;
                    richTextBoxResult.Text += "\n[>>>] Тест " + test + " : настоящий класс: " + realClass + "  предсказанный класс: " + predictedClass;
                }
            }
            Console.WriteLine();
            accuracy = (correct / testNumber) * 100;
            richTextBoxResult.Text += "\n[i] Точность: " + accuracy + "%";
        }

        public void LoadData(string path, DataType dataType)
        {
            StreamReader file = new StreamReader(path);
            string line;
            this.lines = 0;
            richTextBoxResult.Text += "\n[i] Чтение файла из ..." + path;
            while ((line = file.ReadLine()) != null)
            {
                string[] splitLine = line.Split(',').ToArray();
                List<string> lineItems = new List<string>(splitLine.Length);
                lineItems.AddRange(splitLine);
                double[] lineDoubles = new double[lineItems.Count - 1];
                string lineClass = lineItems.ElementAt(lineItems.Count - 1);
                for (int i = 0; i < lineItems.Count - 1; i++)  
                {
                    double val = Double.Parse(lineItems.ElementAt(i).Replace(".", ","));
                    lineDoubles[i] = val;
                }
                if (dataType == DataType.TRAININGDATA)
                {
                    this.trainingSetValues.Add(lineDoubles);
                    this.trainingSetClasses.Add(lineClass);
                }
                else if (dataType == DataType.TESTDATA)
                {
                    this.testSetValues.Add(lineDoubles);
                    this.testSetClasses.Add(lineClass);
                }
                this.lines++;
            }
            richTextBoxResult.Text += "\n[+] Конец. Прочитано... "+ this.lines;
            file.Close();
        }

        private static double EuclideanDistance(double[] sampleOne, double[] sampleTwo)
        {
            double d = 0.0;
            for (int i = 0; i < sampleOne.Length; i++)
            {
                double temp = sampleOne[i] - sampleTwo[i];
                d += temp * temp;
            }
            return Math.Sqrt(d);
        }

        private void btn_link_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/umanets-alexander/knn-iris-dataset");
        }
    }
}
