Class MainWindow

    Private Sub ApplyButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show(DescriptionText.Text)

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As RoutedEventArgs)
        Dim checkboxes As CheckBox() = {WeldCheckbox, AssemblyCheckbox, PlasmaCheckbox, LaserCheckbox, PurchaseCheckbox, LatheCheckbox, DrillCheckbox, FoldCheckbox, RollCheckbox, SawCheckbox}
        For Each item In checkboxes
            item.IsChecked = False
        Next
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub Checkbox_Checked(sender As Object, e As RoutedEventArgs)
        LengthText.Text += DirectCast(sender, CheckBox).Content + " "
    End Sub

    Private Sub FinishDropdown_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        If NoteText Is Nothing Then
            Return
        End If

        Dim combo As ComboBox = DirectCast(sender, ComboBox)
        Dim value As ComboBoxItem = combo.SelectedValue
        NoteText.Text = value.Content
    End Sub
End Class
