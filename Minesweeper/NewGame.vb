Public Class frmNewGame

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        intRowCount = nudRows.Value
        intColCount = nudColumns.Value
        intMineCount = nudMines.Value

        Me.Hide()

    End Sub


    Private Sub radBeginner_CheckedChanged(sender As Object, e As EventArgs) Handles radBeginner.CheckedChanged

        If radBeginner.Checked Then

            nudRows.Value = 9
            nudColumns.Value = 9
            nudMines.Value = 10

        End If

    End Sub

    Private Sub radIntermediate_CheckedChanged(sender As Object, e As EventArgs) Handles radIntermediate.CheckedChanged

        If radIntermediate.Checked Then

            nudRows.Value = 16
            nudColumns.Value = 16
            nudMines.Value = 40

        End If

    End Sub

    Private Sub radExpert_CheckedChanged(sender As Object, e As EventArgs) Handles radExpert.CheckedChanged

        If radExpert.Checked Then

            nudRows.Value = 16
            nudColumns.Value = 30
            nudMines.Value = 99

        End If

    End Sub

    Private Sub radCustom_CheckedChanged(sender As Object, e As EventArgs) Handles radCustom.CheckedChanged

        If radCustom.Checked Then

            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False

        End If

    End Sub


End Class