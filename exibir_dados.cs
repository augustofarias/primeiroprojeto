    public Form1()
        {
            InitializeComponent();
            ExibirDados();
        }
          private void ExibirDados()
        {
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT * FROM Contatos", con);
                adapt.Fill(dt);
                dgvAgenda.DataSource = dt;
            }
            catch
            {
                throw; 
            }
            finally
            {
                con.Close();
            }
        }
          private void btnNovo_Click(object sender, EventArgs e)
    {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtNome.Focus();
   }