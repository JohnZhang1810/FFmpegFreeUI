Partial Public Class 网络功能

    Public Shared Function 创建Agent端点客户端() As AgentEndpointClient
        Return New AgentEndpointClient(
            设置_v6.实例对象.AgentEndPoint,
            设置_v6.实例对象.AgentApiKey,
            设置_v6.实例对象.Agent附加请求头,
            设置_v6.实例对象.Agent附加请求Body)
    End Function

    Public Shared Property 当前是否正在进行本体更新 As Boolean
        Get
            Return 网络功能_v6_软件本体更新.当前是否正在进行本体更新
        End Get
        Set(value As Boolean)
            网络功能_v6_软件本体更新.当前是否正在进行本体更新 = value
        End Set
    End Property

    Public Shared Property 检查软件本体更新最后一次错误 As String
        Get
            Return 网络功能_v6_软件本体更新.检查软件本体更新最后一次错误
        End Get
        Set(value As String)
            网络功能_v6_软件本体更新.检查软件本体更新最后一次错误 = value
        End Set
    End Property

    Public Shared ReadOnly Property 检查软件本体更新下载位置 As String
        Get
            Return 网络功能_v6_软件本体更新.检查软件本体更新下载位置
        End Get
    End Property

    Public Shared Sub 检查软件本体更新()
        网络功能_v6_软件本体更新.检查软件本体更新()
    End Sub

    Public Shared Property 当前是否正在进行更新器更新 As Boolean
        Get
            Return 网络功能_v6_更新器更新.当前是否正在进行更新器更新
        End Get
        Set(value As Boolean)
            网络功能_v6_更新器更新.当前是否正在进行更新器更新 = value
        End Set
    End Property

    Public Shared Property 检查更新器更新最后一次错误 As String
        Get
            Return 网络功能_v6_更新器更新.检查更新器更新最后一次错误
        End Get
        Set(value As String)
            网络功能_v6_更新器更新.检查更新器更新最后一次错误 = value
        End Set
    End Property

    Public Shared ReadOnly Property 检查更新器更新下载位置 As String
        Get
            Return 网络功能_v6_更新器更新.检查更新器更新下载位置
        End Get
    End Property

    Public Shared Sub 检查更新器更新(Optional 强制更新 As Boolean = False)
        网络功能_v6_更新器更新.检查更新器更新(强制更新)
    End Sub

End Class