namespace Solution3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filepath = "myfile1.txt";

            if (File.Exists(filepath) == false)
            {
                try
                {
                    File.Create(filepath);
                    MessageBox.Show($"File: {filepath} , created succefully!");
                    //Application.Restart();
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Failed creating file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"File: {filepath} already exist!");
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = "myfile1.txt";

            try
            {
                StreamWriter ry = new StreamWriter(filepath);
                ry.Write("1st:My name is Ropafadzo");
                ry.WriteLine();
                ry.Write("2nd:I come from Harare");
                ry.WriteLine();
                ry.Write("3rd:I am a software developer.");
                ry.Close();
                this.Close();

                MessageBox.Show($"File written successfully");
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Failed writing file: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filepath = "myfile1.txt";

            if (File.Exists(filepath) == true)
            {
                try
                {
                    File.Delete(filepath);
                    MessageBox.Show($"File: {filepath} , deleted succefully!");
                    //Application.Restart();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Failed deleting file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show($"File: {filepath} doesn't exist!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filepath = "myfile1.txt";
            int i = 0;

            if (File.Exists(filepath) == true)
            {
                try
                {
                    foreach (string line in File.ReadAllLines(filepath))
                    {
                        i += 1;
                        if (i == 1)
                            MessageBox.Show(line);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show($"File: {filepath} doesn't exist!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string filepath = "myfile1.txt";
            int i = 0;

            if (File.Exists(filepath) == true)
            {
                try
                {
                    foreach (string line in File.ReadAllLines(filepath))
                    {
                        i += 1;
                        if (i == 2)
                            MessageBox.Show(line);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show($"File: {filepath} doesn't exist!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string filepath = "myfile1.txt";
            int i = 0;

            if (File.Exists(filepath) == true)
            {
                try
                {
                    foreach (string line in File.ReadAllLines(filepath))
                    {
                        i += 1;
                        if (i == 3)
                            MessageBox.Show(line);
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show($"File: {filepath} doesn't exist!");
            }
        }
    }
}