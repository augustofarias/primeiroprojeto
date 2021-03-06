 private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != ""  && txtEndereco.Text != "" && txtCelular.Text != ""  && txtTelefone.Text != "" && txtEmail.Text != "")
            {
                try
                { 
                cmd = new SqlCommand("UPDATE Contatos SET nome=@nome, endereco=@endereco, celular=@celular,telefone=@telefone,email=@email WHERE id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text.ToUpper());
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text.ToUpper());
                cmd.Parameters.AddWithValue("@celular", txtCelular.Text.ToUpper());
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.ToUpper());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.ToLower());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro atualizado com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    ExibirDados();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }