Module StructuresModule

    Public Structure SignUpRegistrationData
        Public companyId As String
        Public email As String
        Public firstname As String
        Public lastname As String
        Public password As String
    End Structure

    Public Structure AgentData
        Public companyId As String
        Public companyName As String
        Public password As String
        Public GUID As String
        Public deviceId As String
        Public agentVersion As String
        Public ScreenConnect As String
        Public ScanServer As String
        Public ServerKey As String
        Public API_Server As String
        Public DeliveryServer As String
        Public Proactivitee_Server As String
        Public Download_Server As String
        Public Socket_Server As String
        Public Socket_Server_Port As String
    End Structure




End Module
