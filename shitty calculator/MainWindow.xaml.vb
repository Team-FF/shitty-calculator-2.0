Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

        Try

            Dim firstnum As Decimal = CDec(addleft.Text)
            Dim secondnum As Decimal = CDec(addright.Text)
            Dim sum = firstnum + secondnum

            lblSum.Text = CStr(sum)

        Catch ex As System.InvalidCastException

            MessageBox.Show("Please enter numbers only",
                            "Error")

            Console.WriteLine("An error occured")

        Catch ex As Exception

            MessageBox.Show("An unknown error has occured",
                            "Error")

        End Try

    End Sub
    Private Sub lblSum_TextChanged(sender As Object, e As TextChangedEventArgs) Handles lblSum.TextChanged

    End Sub

    Private Sub addleft_TextChanged(sender As Object, e As TextChangedEventArgs) Handles addleft.TextChanged

    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)

        Try

            Dim firstnumm As Decimal = CDec(minusleft.Text)
            Dim secondnumm As Decimal = CDec(minusRight.Text)
            Dim summ = firstnumm - secondnumm

            lbldif.Text = CStr(summ)

        Catch ex As Exception

            MessageBox.Show("Please enter numbers only",
                            "Error")

            Console.WriteLine("An error occured")


        End Try



    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)

        Try

            Dim num As Decimal = CDec(timesleft.Text)
            Dim num2 As Decimal = CDec(timesRight.Text)
            Dim product As Decimal = num * num2

            timeSum.Text = CStr(product)


        Catch ex As Exception

            MessageBox.Show("Please enter numbers only",
                           "Error")

            Console.WriteLine("An error occured")


        End Try



    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)

        Try

            Dim numm As Decimal = CDec(divideLeft.Text)
            Dim nummm As Decimal = CDec(divideRight.Text)
            Dim factor As Decimal = numm / nummm

            divideSum.Text = CStr(factor)


        Catch ex As Exception

            MessageBox.Show("Please enter numbers only",
                           "Error")

            Console.WriteLine("An error occured")


        End Try



    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)

        Me.Close()

    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)


    End Sub
End Class
