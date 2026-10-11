namespace VarakGUI
{
    public partial class Form1 : Form
    {
        List<Var> vars = new List<Var>();
        static int id = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            textBox1.TextChanged += TextBox1_TextChanged;
            dataGridView1.CellClick += DataGridView1_CellClick;
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            DialogResult = MessageBox.Show(
            caption: "Megerősítés",
            text: $"Valóban javaslatot tesz a(z) {varnev.Text} adatainak módosítására?",
            buttons: MessageBoxButtons.YesNo,
            icon: MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
              using(StreamWriter iro = new StreamWriter("../../../forras/javaslat.txt",true))
                {             
                    iro.WriteLine($"{DateTime.Now}  Id:{id+1}     Adatok: {textBox2023.Text}  {textBox2024.Text}  {textBox4.Text}");
                }
            }
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            varnev.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2023.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox2024.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            id = e.RowIndex;
        }

        private void TextBox1_TextChanged(object? sender, EventArgs e)
        {
            var f13 = vars.Where(x => x.Nev.ToLower().Contains(textBox1.Text.ToLower()) && x.Telepules.ToLower().Contains(textBox1.Text.ToLower()));
            dataGridView1.Rows.Clear();
            foreach(var item in f13)
            {
                dataGridView1.Rows.Add(item.Id, item.Nev, item.Telepules, item.Megye, item.Latogato2023, item.Latogato2024, item.Jegyar);
            }
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Read();
            Write();
        }

        private void Write()
        {
            foreach(var item in vars)
            {
                dataGridView1.Rows.Add(item.Id, item.Nev , item.Telepules, item.Megye, item.Latogato2023, item.Latogato2024, item.Jegyar);
            }
        }

        private void Read()
        {


            using (StreamReader olvaso = new StreamReader("../../../forras/varak.txt"))
            {
                olvaso.ReadLine();
                while (!olvaso.EndOfStream)
                {
                    string faszocska = olvaso.ReadLine();
                    vars.Add(new Var(faszocska));
                }
            }
        }
    }
}
