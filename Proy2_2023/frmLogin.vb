Public Class frmLogin

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuariosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Proy2_2023DataSet)

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Proy2_2023DataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.Proy2_2023DataSet.usuarios)

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        If Me.txtPassword.Text = Me.UsuariosDataGridView.CurrentRow.Cells(1).Value.ToString Then
            frmMenu.Show()
            Me.Close()
        Else
            MsgBox("CONTRASEÑA INCORRECTA, INTENTE NUEVAMENTE", MsgBoxStyle.Critical, "ATENCIÓN")
        End If

    End Sub
End Class