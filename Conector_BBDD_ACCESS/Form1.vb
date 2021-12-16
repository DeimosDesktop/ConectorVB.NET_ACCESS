Public Class Form1
    Private Sub PeliculasBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles PeliculasBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PeliculasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.CatalogadorDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CatalogadorDataSet.Peliculas' Puede moverla o quitarla según sea necesario.
        Me.PeliculasTableAdapter.Fill(Me.CatalogadorDataSet.Peliculas)

    End Sub
End Class
