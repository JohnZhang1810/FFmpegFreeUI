Imports LakeUI

Public Class Form_v6_设置_Agent
    Private _正在加载 As Boolean = False

    Private Sub Form_v6_设置_Agent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _正在加载 = True
        Try
            MTB_自定义地址.Text = 设置_v6.实例对象.AgentEndPoint
            MTB_APIKEY.Text = 设置_v6.实例对象.AgentApiKey
            MTB_APIKEY.PasswordChar = "●"c
            MTB_附加请求头.Text = 设置_v6.实例对象.Agent附加请求头
            MTB_附加请求Body.Text = 设置_v6.实例对象.Agent附加请求Body

            ' 清理版只保留用户自定义端点，不提供任何 SP 专属远程端点。
            ModernComboBox1.Visible = False
            ModernComboBox1.Enabled = False
            HtmlColorLabel2.Visible = False
        Finally
            _正在加载 = False
        End Try
    End Sub

    Private Sub MTB_自定义地址_TextChanged(sender As Object, e As EventArgs) Handles MTB_自定义地址.TextChanged
        If _正在加载 Then Exit Sub
        设置_v6.实例对象.AgentEndPoint = MTB_自定义地址.Text.Trim()
    End Sub

    Private Sub MTB_APIKEY_TextChanged(sender As Object, e As EventArgs) Handles MTB_APIKEY.TextChanged
        If _正在加载 Then Exit Sub
        设置_v6.实例对象.AgentApiKey = MTB_APIKEY.Text.Trim()
    End Sub

    Private Sub MTB_附加请求头_TextChanged(sender As Object, e As EventArgs) Handles MTB_附加请求头.TextChanged
        If _正在加载 Then Exit Sub
        设置_v6.实例对象.Agent附加请求头 = MTB_附加请求头.Text
    End Sub

    Private Sub MTB_附加请求Body_TextChanged(sender As Object, e As EventArgs) Handles MTB_附加请求Body.TextChanged
        If _正在加载 Then Exit Sub
        设置_v6.实例对象.Agent附加请求Body = MTB_附加请求Body.Text
    End Sub

    Private Sub MTB_附加请求头_LostFocus(sender As Object, e As EventArgs) Handles MTB_附加请求头.LostFocus
        Try
            Dim unused = AgentEndpointClient.ParseAdditionalHeaders(MTB_附加请求头.Text)
        Catch ex As Exception
            ExFloatingTip(MTB_附加请求头, ex.Message, 2600)
        End Try
    End Sub

    Private Sub MTB_附加请求Body_LostFocus(sender As Object, e As EventArgs) Handles MTB_附加请求Body.LostFocus
        Try
            Dim unused = AgentEndpointClient.ParseExtraBody(MTB_附加请求Body.Text)
        Catch ex As Exception
            ExFloatingTip(MTB_附加请求Body, ex.Message, 2600)
        End Try
    End Sub
End Class