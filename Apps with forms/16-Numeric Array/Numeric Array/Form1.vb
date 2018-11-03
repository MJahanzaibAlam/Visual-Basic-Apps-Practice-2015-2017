Public Class Form1
    Dim numbers_int(4) As Integer
    Dim currentIndex_int As Integer
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        currentIndex_int = -1
    End Sub

    Private Sub btnAddArray_Click(sender As System.Object, e As System.EventArgs) Handles btnAddArray.Click
        Dim numberAdded_int As Integer
        numberAdded_int = Me.txtInput.Text
        If (numberAdded_int > 100) Or (numberAdded_int < 0) Then
            MsgBox("Please enter a number between 0 and 100!")
        Else
            If currentIndex_int = 4 Then
                MsgBox("The array is full!")
            Else : currentIndex_int += 1
                numbers_int(currentIndex_int) = numberAdded_int
                txtInput.Text = ""
                txtInput.Focus()
            End If
        End If
    End Sub

    Private Sub btnDisplayArray_Click(sender As System.Object, e As System.EventArgs) Handles btnDisplayArray.Click
        Dim index_int As Integer = 0
        lstNumbers.Items.Clear()
        For index_int = 0 To currentIndex_int
            lstNumbers.Items.Add(numbers_int(index_int))
        Next
    End Sub

    Private Sub btnFindNumber_Click(sender As System.Object, e As System.EventArgs) Handles btnFindNumber.Click
        Dim index_int As Integer = 0
        Dim found_bool As Boolean = False
        Dim searchNumber_int As Integer = 0
        searchNumber_int = txtSearchNumber.Text
        Do While (found_bool = False) And (index_int <= currentIndex_int)
            If numbers_int(index_int) = searchNumber_int Then
                found_bool = True
            Else
                index_int += 1
            End If
        Loop
        If found_bool Then
            Me.lbldisplaysearch.text = "This number is at position " & index_int & " of the array"
        Else
            Me.lblDisplaySearch.Text = "This number is NOT in the array"
        End If
    End Sub
End Class
