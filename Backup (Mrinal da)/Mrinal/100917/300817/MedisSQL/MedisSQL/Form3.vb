Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TestDataSet.fetchstudent' table. You can move, or remove it, as needed.
        ' Me.FetchstudentTableAdapter.Fill(Me.TestDataSet.fetchstudent)
        Try
            populateName()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub populateName()
        Try
            Dim ds As DataSet
            ds = Utility.ExecQueryDS("fetchstudent", Utility.CustomCommandType.StoredPorcedure, Nothing)

            cboNme.DataSource = ds.Tables(0)
            ''cboNme.Items.Insert(0, "Select")

            'cboNme.Items.Insert(i + 1, ds.Tables(0).Rows(i).Item(1))
            cboNme.DisplayMember = "name"
            cboNme.ValueMember = "id"
            'cboNme.DataBindings()
            ''cboNme.
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboNme_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboNme.SelectedIndexChanged

    End Sub

    Private Sub dg_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
End Class