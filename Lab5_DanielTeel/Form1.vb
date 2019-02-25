Public Class Form1
    'Lab 5
    '2015 Fall Semester
    'Daniel Teel
    'I fully understand the following statement. 
    'OU PLAGIARISM POLICY 
    'All members of the academic community at Oakland are expected to practice and uphold ‘standards of academic integrity and honesty. An instructor is expected to inform and instruct ‘students about the procedures and standards of research and documentation required of students ‘in fulfilling course work. A student is expected to follow such instructions and be sure the rules ‘and procedures are understood in order to avoid inadvertent misrepresentation of his work. ‘Students must assume that individual (unaided) work on exams and lab reports and documentation ‘of sources is expected unless the instructor specifically says that is not necessary. 
    'The following definitions are some examples of academic dishonesty: 
    'Plagiarizing from work of others. Plagiarism is using someone else's work or ideas without ‘giving the other person credit; by doing this, a student is, in effect, claiming credit for ‘someone else's thinking. Whether the student has read or heard the information he uses, ‘the student must document the source of information. When dealing with written sources, ‘a clear distinction would be made between quotations (which reproduce information from ‘the source word-for-word within quotation marks) and paraphrases (which digest the ‘source information and produce it in the student's own words). Both direct quotations and ‘paraphrases must be documented. Just because a student rephrases, condenses or selects ‘from another person's work, the ideas are still the other person's, and failure to give ‘credit constitutes misrepresentation of the student's actual work and plagiarism of ‘another's ideas. Naturally, buying a paper and handing it in as one's own work is ‘plagiarism. 
    'Cheating on lab reports falsifying data or submitting data not based on student's own work.

    Dim voltage, r1, r2, r3, v1, v2, v3, current As Double

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtV1.Text = ""
        txtV2.Text = ""
        txtV3.Text = ""
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        r1 = Val(txtR1.Text)
        r2 = Val(txtR2.Text)
        r3 = Val(txtR3.Text)

        voltage = trckPower.Value

        If chkRemove.Checked Then
            current = voltage / (r1 + r2)
            lblCurrent.Text = CStr(current)
            txtV1.Text = CStr(current * (r1))
            txtV2.Text = CStr(current * (r2))
        Else
            current = voltage / (((1 / r1) + (1 / (r2 + r3)) ^ (-1)))
            lblCurrent.Text = CStr(current)
            txtV1.Text = CStr((voltage / (r1 + r2)) * (r1))
            txtV2.Text = CStr((voltage / (r1 + r2)) * (r2))
            txtV3.Text = CStr(voltage)
        End If
    End Sub

    Private Sub chkRemove_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemove.CheckedChanged
        If chkRemove.Checked Then
            picEx.Visible = True
            picIn.Visible = False
        Else
            picEx.Visible = False
            picIn.Visible = True

        End If
    End Sub

    Private Sub trckPower_Scroll(sender As Object, e As EventArgs) Handles trckPower.Scroll
        lblVolt.Text = CStr(trckPower.Value)
        voltage = trckPower.Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
