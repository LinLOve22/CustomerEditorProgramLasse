namespace GUI
{
    public partial class Form1 : Form
    {
        private readonly Abstractions.Interfaces.Services.ICustomerService _customerService;
        public Form1(Abstractions.Interfaces.Services.ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}