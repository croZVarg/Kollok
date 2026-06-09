namespace Kollok
{
    public partial class Form1 : Form
    {
        List<int> chosenConnectors = new List<int> { };
        int AllPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxWant_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<ClassConnector> constantConnectors = new List<ClassConnector>
            {
                new ClassConnector("Силовой ВВГ", 3),
                new ClassConnector("Интернетный NYM", 4),
                new ClassConnector("Провод ПВС", 2),
                new ClassConnector("Коаксиальный RG-6", 3)
            };
            listBoxReady.DataSource = constantConnectors;
        }

        private void listBoxReady_DoubleClick(object sender, EventArgs e)
        {
            listBoxWant.Items.Add(listBoxReady.SelectedValue);
            ClassConnector want = (ClassConnector)listBoxReady.SelectedItem;
            AllPrice += want.Price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllPrice *= Convert.ToInt32(textBoxCM.Text);
            labelItog.Text = $"Итоговая цена ------------ {AllPrice} рублей";
            labelItog.Visible = true;
        }
    }
}
