'Name: William Wells
'Date: 03/29/2019
'application calculates the price of T-Shirts for consumers 
'price is based on size and the addition of names or pictures onto the T-shirt.
'price varies for male and female

Public Class MainForm

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        'Declaring Variables
        Dim totalPrice As Double
        Dim numOrder As Integer

        ' Number of Tees from the text box
        numOrder = Convert.ToInt32(numOrdersTextbox.Text)

        'Set total price to 0
        totalPrice = 0

        'if Men radio is checked
        If menRadio.Checked Then

            'if S is selected
            If smallRadio.Checked Then
                'AA tee shirt price
                totalPrice = 17.75

            ElseIf largeRadio.Checked Or mediumRadio.Checked Then
                'Ad tee shirt price
                totalPrice = 19.75
            End If

            'if picture is selected
            If pictureBox.Checked Then

                'if S or M selected
                If smallRadio.Checked Or mediumRadio.Checked Then
                    'Add tee shirt price
                    totalPrice = totalPrice + 5

                ElseIf largeRadio.Checked Then
                    'Add tee shirt price
                    totalPrice = totalPrice + 6
                End If
            End If

            'if name is selected
            If nameBox.Checked Then
                totalPrice = totalPrice + 7.5
            End If
            'Multiply number of Tees
            totalPrice = totalPrice * numOrder
            'Add sales tax
            totalPrice = totalPrice + (totalPrice * 0.02)

            'if woman radio is checked
        Else
            'Add tee shirt price
            totalPrice = 17.75

            'if picture is selected
            If pictureBox.Checked Then
                totalPrice = totalPrice + 5
            End If

            'if name is selected
            If nameBox.Checked Then
                totalPrice = totalPrice + 7.5
            End If

            'Multiply number of Tees
            totalPrice = totalPrice * numOrder

            'Add sales tax
            totalPrice = totalPrice + (totalPrice * 0.02)

        End If

        'write result to total price text box
        totalPriceTextBox.Text = "$" + totalPrice.ToString("#.##")

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'exit button to close program
        Application.Exit()

    End Sub


End Class
