Imports System.IO
Public Class NewExplorer
    Private Sub BackToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripButton.Click
        WebBrowser1.GoBack()
        ForwardToolStripButton.Enabled = True
    End Sub

    Private Sub ForwardToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripButton.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NewExplorer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each arg As String In My.Application.CommandLineArgs
            Select Case Trim(LCase(arg))
                Case "/photos"
                    WebBrowser1.Navigate("file://C:\Users\" + System.Environment.UserName + "\pictures")
                Case "/music"
                    WebBrowser1.Navigate("file://C:\Users\" + System.Environment.UserName + "\music")
                Case "/docs"
                    WebBrowser1.Navigate("file://C:\Users\" + System.Environment.UserName + "\documents")
                Case "/user"
                    WebBrowser1.Navigate("file://C:\Users\" + System.Environment.UserName + "\")
                Case "/fav"
                    WebBrowser1.Navigate("file://C:\Users\" + System.Environment.UserName + "\favorites")
                Case "/downloads"
                    WebBrowser1.Navigate("file://C:\Users\" + System.Environment.UserName + "\downloads")
                Case "/videos"
                    WebBrowser1.Navigate("file://C:\Users\" + System.Environment.UserName + "\videos")
                Case "-search"
                    WebBrowser1.Navigate(Application.UserAppDataPath + "\tempsearch.search-ms")
                    Me.Text = "Search Results in C:\"
            End Select
        Next
        ComboBox1.Items.Clear()
        For Each drv As DriveInfo In DriveInfo.GetDrives
            ComboBox1.Items.Add(drv)
        Next
    End Sub


    Private Sub ComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub FoldersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextLabels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs)

    End Sub

    Private Sub ToolBarToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub WebBrowser1_Navigated(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebBrowser1.Navigated

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        WebBrowser1.Navigate(WebBrowser1.Url.ToString + "/..")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim searchbase As String = My.Resources.SearchDoc.ToString.ToString.ToString.ToString
        Dim searh As String = searchbase.Replace("abcdefg", ToolStripTextBox1.Text)
        If My.Computer.FileSystem.FileExists(Application.UserAppDataPath + "\tempsearch.search-ms") = False Then
            File.Create(Application.UserAppDataPath + "\tempsearch.search-ms").Dispose()
        End If
        Dim objWriter As New System.IO.StreamWriter(Application.UserAppDataPath + "\tempsearch.search-ms")
        objWriter.Write(searh)
        objWriter.Close()
        WebBrowser1.Navigate(Application.UserAppDataPath + "\tempsearch.search-ms")
        Me.Text = "Search Results for " + ToolStripTextBox1.Text + " in C:\"
        ComboBox1.Text = "search://" + ToolStripTextBox1.Text
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        WebBrowser1.Navigate(ComboBox1.Text)
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            WebBrowser1.Navigate(ComboBox1.Text)

        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        'First toggle the checked state of the associated menu item
        ToolStripButton3.Checked = Not ToolStripButton3.Checked

        'Change the Folders toolbar button to be in sync
        ToolStripButton3.Checked = ToolStripButton3.Checked

        ' Collapse the Panel containing the TreeView.
        SplitContainer1.Panel1Collapsed = Not ToolStripButton3.Checked
    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click
        ToolStripTextBox1.Clear()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        If WebBrowser1.Url.ToString.Contains("tempsearch.search-ms") = False Then
            Me.Text = WebBrowser1.DocumentTitle + " - Codenamed NewExplorer"
            ListView1.Items.Add(ComboBox1.Text)
            ComboBox1.Text = WebBrowser1.Url.ToString.Replace("file:///", "").ToString
        End If
        If WebBrowser1.Url.ToString.Contains("tempsearch.search-ms") = False Then
            Me.Text = WebBrowser1.DocumentTitle
            ToolStripButton5.Enabled = True
        Else
            ToolStripButton5.Enabled = False
        End If
    End Sub
End Class




