 private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar este registro ?", "Agenda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new SqlCommand("DELETE Contatos WHERE id=@id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registro deletado com sucesso...!");
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
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }
          private void dgvAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvAgenda.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dgvAgenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtEndereco.Text = dgvAgenda.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCelular.Text = dgvAgenda.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtTelefone.Text = dgvAgenda.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtEmail.Text = dgvAgenda.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            catch { }
        }