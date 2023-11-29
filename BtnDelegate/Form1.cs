namespace BtnDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b=new Button();
            b.Text = "Click Me";
            b.Size = new Size(100, 20);
            b.Location = new Point(250,250);
            this.Controls.Add(b);
            //b.Click += new EventHandler(b_Click); //Before Anonymous
            b.Click += delegate (object sender, EventArgs e) //After Anonymous
            {
                MessageBox.Show("Hellooo!");
            };
        }
        /*private void b_Click(object sender, EventArgs e) //Before Anonymous
        {
            MessageBox.Show("Hellooo!");
        }*/
    }
}