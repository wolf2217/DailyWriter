Module Users
    Public db As New FunctionsDataContext

    Public Function CreateAccount(ByVal username As String, ByVal password As String)
        username = Home.userReg.Text
        password = Home.passReg.Text

        'check to see if user exists than create if false
        Dim checkUser = From dw_users In db.dw_users
                        Where dw_users.Username = username

        If checkUser.Count = 1 Then
            'MsgBox("Username already exists, try another username", MsgBoxStyle.Information)
            Notify.Show()
            Notify.lblMessage.Text = Home.userReg.Text & " has been taken, try another username"
        Else
            'create the user
            Dim createUser = New dw_user With {
                .Created = Date.Today.ToLongDateString(),
                .Password = password,
                .Username = username
            }
            db.dw_users.InsertOnSubmit(createUser)
            Try
                db.SubmitChanges()
                My.Settings.Username = username
                My.Settings.Save()
                Notify.Show()
                Notify.lblMessage.Text = Home.userReg.Text & " has been created and we will now log you in"
                Home.Hide()
                Dashboard.Show()
                Home.Close()
            Catch ex As Exception
                Notify.Show()
                Notify.lblMessage.Text = Home.userReg.Text & " can not be created because " & ex.Message
            End Try
        End If
        Return 0
    End Function

    Public Function Login(ByVal username As String, ByVal password As String)
        username = Home.userLogin.Text
        password = Home.passLogin.Text

        'check to see if user auth is true
        Dim checkUser = From pw_users In db.dw_users
                        Where pw_users.Username = username And pw_users.Password = password

        If checkUser.Count = 1 Then
            My.Settings.Username = username
            My.Settings.Save()
            Home.Hide()
            Dashboard.Show()
            Home.Close()
        Else
            Notify.Show()
            Notify.lblMessage.Text = "Whoops! Login failed" & vbNewLine & "Please try again"
        End If
        Return 0
    End Function
End Module
