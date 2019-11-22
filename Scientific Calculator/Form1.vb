Public Class clear

    Private Sub numberzero_Click(sender As Object, e As EventArgs) Handles numberzero.Click
        this.textBox1.Text = "";
        Input += "0";
        this.textBox1.Text

    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        operand2 = Input();
            Double num1, num2;
            Double.TryParse(operand1, out num1);
            Double.TryParse(operand2, out num2);

            If (operation == '+')
            {
                result = num1 + num2;
                TextBox1.Text = result.ToString();
            }
            ElseIf (operation == '-')
            {
                result = num1 - num2;
                TextBox1.Text = result.ToString();
            }
            ElseIf (operation == '*')
            {
                result = num1 * num2;
                TextBox1.Text = result.ToString();
            }
            ElseIf (operation == '/')
            {
                If(num2!= 0)
                {
                    result = num1 / num2;
                    TextBox1.Text = result.ToString();
                }
                Else
                {
                    TextBox1.Text = "DIV/Zero!";
                }

            }
    End Sub

    Private Sub number1_Click(sender As Object, e As EventArgs) Handles number1.Click
        this.textBox1.Text = "";
        Input += "1";
        this.textBox1.Text
    End Sub

    Private Sub number2_Click(sender As Object, e As EventArgs) Handles number2.Click
        this.textBox1.Text = "";
        Input += "2";
        this.textBox1.Text
    End Sub

    Private Sub number3_Click(sender As Object, e As EventArgs) Handles number3.Click
        this.textBox1.Text = "";
        Input += "3";
        this.textBox1.Text
    End Sub

    Private Sub number4_Click(sender As Object, e As EventArgs) Handles number4.Click
        this.textBox1.Text = "";
        Input += "4";
        this.textBox1.Text
    End Sub

    Private Sub number5_Click(sender As Object, e As EventArgs) Handles number5.Click
        this.textBox1.Text = "";
        Input += "5";
        this.textBox1.Text
    End Sub

    Private Sub number6_Click(sender As Object, e As EventArgs) Handles number6.Click
        this.textBox1.Text = "";
        Input += "6";
        this.textBox1.Text
    End Sub

    Private Sub clear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub number7_Click(sender As Object, e As EventArgs) Handles number7.Click
        this.textBox1.Text = "";
        Input += "7";
        this.textBox1.Text
    End Sub

    Private Sub number8_Click(sender As Object, e As EventArgs) Handles number8.Click
        this.textBox1.Text = "";
        Input += "8";
        this.textBox1.Text
    End Sub

    Private Sub number9_Click(sender As Object, e As EventArgs) Handles number9.Click
        this.textBox1.Text = "";
        Input += "9";
        this.textBox1.Text
    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        operand1 = Input();
            operation = '+';
            Input() = String.Empty;

    End Sub

    Private Sub minus_Click(sender As Object, e As EventArgs) Handles minus.Click
        operand1 = Input();
            operation = '-';
            Input() = String.Empty;
    End Sub

    Private Sub multiply_Click(sender As Object, e As EventArgs) Handles multiply.Click
        operand1 = Input();
            operation = '*';
            Input() = String.Empty;
    End Sub

    Private Sub sin_Click(sender As Object, e As EventArgs) Handles sin.Click

    End Sub

    Private Sub cos_Click(sender As Object, e As EventArgs) Handles cos.Click

    End Sub

    Private Sub log_Click(sender As Object, e As EventArgs) Handles log.Click

    End Sub

    Private Sub tan_Click(sender As Object, e As EventArgs) Handles tan.Click

    End Sub

    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        operand1 = Input();
            operation = '/';
            Input() = String.Empty;
    End Sub

    Private Sub point_Click(sender As Object, e As EventArgs) Handles point.Click
        this.textBox1.Text = "";
        Input += ".";
        this.textBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clr.Click
        this.textBox1.Text = "";
            this.input = String.Empty;
            this.operand1 = String.Empty;
            this.operand2 = String.Empty;

    End Sub
End Class
