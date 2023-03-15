Imports System.IO
Imports System.Linq
Imports System.Management
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Web.Script.Serialization
Imports Microsoft.Win32
Imports System.Collections
Imports System.ServiceProcess
Imports System.Net
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Security.Principal
Imports WUApiLib
Imports System.Net.Sockets
Imports System.Net.NetworkInformation
Imports System.Data.SqlClient
Imports System.DirectoryServices
Imports EaseeControl.MetroTilePanel
Imports System.Security.Cryptography
Imports System.IO.Compression
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Reflection.Emit
Imports Script_Agent.ToolBox


Module Module1



    'US
    Public TechID As String = "20621"
    Public DnHID As String = "24159"
    Public StaplesID As String = "23588"
    Public StaplesRetailID As String = "24162"
    Public NewEGGID As String = "23862"
    Public Office_Depot_SMB As String = "23515"
    Public OptimumDeskID As String = "23569"
    Public PlusID As String = "23526"
    Public PCMaticID As String = "23861"
    Public TrueID As String = "23927"
    Public WalmartOnlineID As String = "23572"
    Public WalmartComID As String = "23559"
    Public CompanyCom As String = "20686"
    Public EaseeAccess As String = "23571"
    Public EaseeControlID As String = "23567"
    Public GoAgilantID As String = "23570"
    Public Startech365 As String = "23589"
    Public Synnex As String = "23863"



    'RO
    Public ClassITID As String = "8511"
    Public Class_IT_Home As String = "19572"
    Public Aectra As String = "12434"
    Public Aerodynamics As String = "19834"
    Public Agroconcept As String = "20165"
    Public Aims_Human_Capital_Romania As String = "10117"
    Public Aktiv_Power As String = "15937"
    Public AMREST_FOOD_Burger_King As String = "1000148"
    Public Angelini_Pharmaceuticals As String = "1000111"
    Public April_Romania As String = "19490"
    Public Archivit As String = "14313"
    Public Artemob_International As String = "8585"
    Public As24_Tankservice As String = "191"
    Public ASHAY_SERVICES_SRL As String = "1000149"
    Public Auto_Erebus As String = "1000160"
    Public Avocati_Corina_Popescu As String = "19757"
    Public B2Holding As String = "1000005"
    Public B2IFN As String = "23574"
    Public Banca_Romaneasca As String = "23544"

    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"
    'Public XXX As String = "19757"



    ''And more...


    Public companiesUS As New List(Of String) From
            {
            "Company.com",
            "EaseeAccess",
            "EaseeControl",
            "GoAgilant",
            "NewEgg",
            "Office Depot SMB",
            "OptimumDesk",
            "PcMatic",
            "Plus",
            "Staples",
            "Staples Retail",
            "Startech365",
            "Synnex",
            "TechServices",
            "True Solutions",
            "Walmart Online",
            "Walmart.com",
            "Your Help Desk HQ"
}

    Public companiesRO As New List(Of String) From
            {
    "Aectra",
    "Agroconcept",
    "Aktiv Power",
    "AMREST FOOD (Burger King)",
    "Angelini Pharmaceuticals",
    "April Romania",
    "Archivit",
    "Artemob International",
    "ASHAY SERVICES S.R.L.",
    "Aerodynamics",
    "Avocati Corina Popescu",
    "B2Holding",
    "B2IFN",
    "Banca Romaneasca",
    "Brady Trade",
    "Bravo Trading",
    "BRCC",
    "BRD",
    "Cabot Transfer Pricing",
    "Cabinet Avocat Liana Petrovici",
    "Caranda Baterii",
    "Carpatina",
    "CC A Wood Oltenasu & Asociatii",
    "Class IT Home",
    "Class It Outsourcing",
    "Confederatia Concordia",
    "Condor",
    "Courbi",
    "Crama Ceptura",
    "CRYSTAL DENTAL CLINIC",
    "Dasauto Premier",
    "Danubius Exim",
    "Delamode Romania",
    "Eldomir",
    "Elefant",
    "EmpireBetting GetsBet",
    "Eurest Rom",
    "Estee Lauder Romania",
    "Eurolines",
    "F64",
    "Fatrom",
    "FDLaw",
    "FIC - Foreign Investors Council",
    "Gaspeco",
    "Geca Impex Pm",
    "Generali",
    "Holiday Office",
    "Human Invest",
    "Human Resources Real Profesional",
    "ICHB",
    "ICPA",
    "Iridex Group Import-Export",
    "Jerry S Pizza",
    "JTI",
    "Kick Off Events",
    "Klass Wagen",
    "Labservice",
    "Lease Plan",
    "Leroy Merlin",
    "LIDL",
    "Libro Events",
    "LINDE GLOBAL SERVICES ROMANIA",
    "London Brokers",
    "Lidea Seeds",
    "M&C Business",
    "Making Off Promotion",
    "Marea Loja Nationala Din Romania",
    "Mega Image",
    "Melinda Instal",
    "Meat Systems",
    "Miele Appliances",
    "MPC Trade Marketing",
    "NetConnect",
    "NEW MAO PROTECT",
    "Nolte Home studio",
    "One Distribution Company",
    "OptimumDesk",
    "OTTO BROKER DE ASIGURARE",
    "Patberg INT",
    "Perrigo Romania (Hipocrate)",
    "Producton",
    "Propaganda Consult",
    "Publiter",
    "Quality Crops",
    "Quanta Resurse Umane",
    "Raureni",
    "Radar Group Import Export",
    "REWE",
    "RIELLO ROMANIA",
    "Romanian American Foundation",
    "Romanian Franchise Systems",
    "Roche Romania",
    "Rotours Incoming Concept",
    "Salzgitter Mannesmann Distributie SRL",
    "Sibesoft",
    "SITE INSTALATII",
    "Slavia Pharm",
    "Smartree Salarizare",
    "Socar",
    "Socecc",
    "Soter & Partners",
    "Starbucks",
    "StarTechAcademy",
    "Stera Chemicals"}






    '191 As24 Tankservice
    '252 Romanian Franchise Systems
    '270 United Way
    '580 Provident Financial Romania Ifn
    '792 Propaganda Consult
    '1391    Stera Chemicals
    '1540    Quanta Resurse Umane
    '3126    Perrigo Romania (Hipocrate)
    '4463    Eurest Rom
    '5923    Zitec Com
    '6314    Sixt New Kopel Romania
    '6520    Iridex Group Import-Export
    '6788    C C A Wood Oltenasu & Asociatii
    '7028    Danubius Exim
    '8585    Artemob International
    '8952    The Group
    '9431    Mega Image
    '9953    Far Est Windows
    '10117   Aims Human Capital Romania
    '11625   Brady Trade
    '11841   Human Invest

    '12576   Lease Plan
    '12642   Transpeco Logistic& Distribution
    '12814   Uniway
    '14033   Socecc

    '14443   Starbucks
    '14591   Miele Appliances
    '14617   Kick Off Events
    '14989   Making Off Promotion
    '15364   Geca Impex Pm
    '15539   Wienerberger Sisteme De Caramizi
    '15826   Servicii Salubritate Bucuresti

    '15967   Carpatina
    '16420   Jerry S Pizza
    '16609   Labservice
    '16985   Senso Ambiente
    '17424   Marea Loja Nationala Din Romania
    '18403   OTTO BROKER DE ASIGURARE
    '18616   FDLaw
    '18830   EmpireBetting GetsBet
    '18874   Human Resources Real Profesional
    '19089   SITE INSTALATII
    '19488   Publiter
    '19527   Courbi
    '19578   OptimumDesk
    '19585   Gaspeco
    '19606   Caranda Baterii
    '19666   London Brokers
    '19699   NetConnect
    '19708   FIC - Foreign Investors Council
    '19723   Patberg INT
    '19741   RENANIA TRADE SRL
    '19756   Condor
    '19757   Avocati Corina Popescu
    '19780   Timas
    '19824   Valoris
    '19830   Smartree Salarizare
    '19832   Serbel
    '19834   Aerodynamics
    '19836   Eldomir
    '19839   Delamode Romania
    '19841   M&C Business
    '19846   Holiday Office
    '19848   Eurolines
    '19854   Rotours Incoming Concept
    '19856   REWE
    '19861   Oma Vision
    '19883   Vest Food Service
    '19899   F64
    '19912   Elefant
    '19934   Bravo Trading
    '19940   Top Gel
    '19959   Generali
    '19998   Cabinet Avocat Liana Petrovici
    '20001   Meat Systems
    '20002   ICPA
    '20007   Prion Poct
    '20008   CH Beck
    '20016   Energomontaj SA
    '20061   Cabot Transfer Pricing
    '20084   GP Holding
    '20129   BRCC
    '20141   RIELLO ROMANIA
    '20150   Crama Ceptura
    '20153   Radar Group Import Export
    '20165   Agroconcept
    '20167   Libro Events
    '20191   Producton
    '20196   Dasauto Premier
    '20232   Fatrom
    '20266   MPC Trade Marketing
    '20526   Simacek
    '20532   JTI
    '20554   Leroy Merlin
    '20557   CRYSTAL DENTAL CLINIC
    '20558   Veraltis Assets Management(Orange)
    '20559   LIDL
    '20581   Slavia Pharm
    '20622   Quality Crops
    '20629   Estee Lauder Romania
    '20636   Why Not
    '23503   Soter & Partners
    '23506   Railing Design
    '23508   Roche Romania
    '23529   Salzgitter Mannesmann Distributie SRL
    '23532   StarTechAcademy
    '23534   Laboratoires Thea Pharma SRL
    '23535   New MAO PROTECT
    '23537   Realsol
    '23544   Banca Romaneasca
    '23568   Tentrom Paradise SRL
    '23570   Melinda Instal
    '23574   B2IFN
    '1000035 Confederatia Concordia
    '1000067 Piramid International(Atifco Foods)
    '1000080 Romanian American Foundation
    '1000081 Yougov
    '1000083 Test nou
    '1000089 Vector International
    '1000091 Casa Rusu (orange)
    '1000095 BRD
    '1000109 ICHB
    '1000111 Angelini Pharmaceuticals
    '1000119 One Distribution Company
    '1000136 Tiriac-Orange
    '1000137 TAROM S.A.
    '1000139 TechLine Project Design SRL (Logis Aluminium)
    '1000147 Trend Consult
    '1000148 AMREST FOOD (Burger King)
    '1000149 ASHAY SERVICES S.R.L.
    '1000150 LINDE GLOBAL SERVICES ROMANIA
    '1000151 CIT ONE
    '1000152 Sibesoft
    '1000157 Klass Wagen
    '1000159 Socar
    '1000160 Auto Erebus
    '1000161 Build Agent
    '1000163 Zepter
    '1000164 Token Payment Services
    '1000165  Lidea Seeds
    '1000167 Nolte Home studio
    '1000168 Biroul de Credit
    '1000169 General Dynamics (Orange)
    '1000170 Raureni
    '1000005 B2Holding








    Public companyID As String
    Public companyLogo As Image
    Public isCompanyBeta As String



    Function Encrypt(ByVal plainText As String) As String
        Try
            Dim passPhrase As String = "STEAUA"
            Dim saltValue As String = "BUCURESTI"
            Dim hashAlgorithm As String = "SHA1"
            Dim passwordIterations As Integer = 2
            Dim initVector As String = "@1B2c3D4e5F6g7H8"
            Dim keySize As Integer = 256
            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)
            Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)
            Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)
            Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
            Dim symmetricKey As New RijndaelManaged()
            symmetricKey.Mode = CipherMode.CBC
            Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)
            Dim memoryStream As New MemoryStream()
            Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
            cryptoStream.FlushFinalBlock()
            Dim cipherTextBytes As Byte() = memoryStream.ToArray()
            memoryStream.Close()
            cryptoStream.Close()
            Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
            Return cipherText
        Catch
            Return plainText
        End Try
    End Function


    Function Decrypt(ByVal cipherText As String) As String
        Try
            Dim passPhrase As String = "STEAUA"
            Dim saltValue As String = "BUCURESTI"
            Dim hashAlgorithm As String = "SHA1"
            Dim passwordIterations As Integer = 2
            Dim initVector As String = "@1B2c3D4e5F6g7H8"
            Dim keySize As Integer = 256
            Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
            Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)
            Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)
            Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)
            Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
            Dim symmetricKey As New RijndaelManaged()
            symmetricKey.Mode = CipherMode.CBC
            Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)
            Dim memoryStream As New MemoryStream(cipherTextBytes)
            Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
            Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
            Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
            memoryStream.Close()
            cryptoStream.Close()
            Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)
            Return plainText
        Catch
            Return cipherText
        End Try
    End Function

    Public Function WEBEncrypt(ByVal plainText As String) As String
        Return php_encrypt_aes256(plainText, "54EDA16A7E700C51A98BE8F4C128646A", "7E226F48F6D37F74")
    End Function

    Public Function WEBDecrypt(ByVal cipherText As String) As String
        Return php_decrypt_aes256("54EDA16A7E700C51A98BE8F4C128646A", "7E226F48F6D37F74", cipherText)
    End Function

    Private Function php_decrypt_aes256(ByVal php_password As String, ByVal php_iv As String, ByVal php_data As String) As String
        Try
            Dim key As Byte() = php_encode(php_password, 32)
            Dim iv As Byte() = php_encode(php_iv, 16)
            Dim buff As Byte() = Encoding.ASCII.GetBytes(php_data)

            Using aes As Aes = Aes.Create()
                Using decryptor As ICryptoTransform = aes.CreateDecryptor(key, iv)
                    buff = Convert.FromBase64String(php_data)
                    Return ASCIIEncoding.ASCII.GetString(decryptor.TransformFinalBlock(buff, 0, buff.Length))
                End Using
            End Using
        Catch
        End Try
        Return ""
    End Function
    Private Function php_encode(ByVal php_string As String, ByVal expectedLength As Integer) As Byte()
        Dim temp As Byte() = Encoding.ASCII.GetBytes(php_string)

        If temp.Length = expectedLength Then
            Return temp
        End If

        Dim ret As Byte() = New Byte(expectedLength - 1) {}
        Buffer.BlockCopy(temp, 0, ret, 0, Math.Min(temp.Length, expectedLength))
        Return ret
    End Function

    Private Function php_encrypt_aes256(ByVal php_data As String, ByVal php_password As String, ByVal php_iv As String) As String
        Try
            Dim key As Byte() = php_encode(php_password, 32)
            Dim iv As Byte() = php_encode(php_iv, 16)
            Dim data As Byte() = Encoding.ASCII.GetBytes(php_data)

            Using aes As Aes = Aes.Create()

                Using encryptor As ICryptoTransform = aes.CreateEncryptor(key, iv)
                    Return Convert.ToBase64String(encryptor.TransformFinalBlock(data, 0, data.Length))
                End Using
            End Using
        Catch
        End Try
        Return ""
    End Function


    Function Reg(ByVal Path As String) As String
        Dim ZX As String = "HKLM\" & Path & vbNewLine
        Try
            Dim rk As RegistryKey = Registry.LocalMachine.CreateSubKey(Path)
            For Each skName As String In rk.GetValueNames
                ZX = ZX & Decrypt(skName) & " : "
                ZX = ZX & Decrypt(Registry.LocalMachine.CreateSubKey(Path).GetValue(skName)) & vbNewLine
            Next
            Try
                If rk.SubKeyCount > 0 Then
                    Try
                        For Each subKeyName As String In rk.GetSubKeyNames()
                            Dim Thispath As String = Path + "\" + subKeyName
                            ZX = ZX & vbNewLine & Reg(Thispath)
                        Next
                    Catch
                    End Try
                End If
            Catch
            End Try
        Catch ex As Exception
        End Try
        Return ZX
    End Function


    Sub AgentCheck()
        On Error Resume Next
        Dim N As RegistryKey
        Dim FILE_NAME As String = System.IO.Path.GetTempPath & "\ODRegDecrypted.txt"
        Dim ZX As String = Reg("SOFTWARE\Class IT") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\OptimumDesk") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\Easee Control") & vbNewLine
        ZX = ZX & Reg("SOFTWARE\PCMATIC") & vbNewLine
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME)
        objWriter.Write(ZX)
        objWriter.Close()
        System.Diagnostics.Process.Start("notepad.exe", FILE_NAME)
    End Sub

    Function GetExePath(fileName As String) As String
        Return System.IO.Path.GetFullPath(AppDomain.CurrentDomain.BaseDirectory & fileName)
    End Function


End Module
