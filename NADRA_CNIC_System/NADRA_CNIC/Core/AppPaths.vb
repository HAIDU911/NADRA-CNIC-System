Imports System.IO

''' <summary>
''' Central helper that resolves every folder/file location used by the application.
''' The database and captured photographs live in the user's %APPDATA% profile so the
''' program keeps working even when it is started from a read-only location (CD/USB).
''' </summary>
Friend NotInheritable Class AppPaths

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property ProductName As String = "NADRA_CNIC_System"

    ''' <summary>Root data folder: %APPDATA%\NADRA_CNIC_System</summary>
    Public Shared ReadOnly Property DataRoot As String =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ProductName)

    ''' <summary>Microsoft Access database file.</summary>
    Public Shared ReadOnly Property DatabaseFile As String = Path.Combine(DataRoot, "nadra.mdb")

    ''' <summary>Folder where captured / imported citizen photographs are stored.</summary>
    Public Shared ReadOnly Property PhotosFolder As String = Path.Combine(DataRoot, "photos")

    ''' <summary>Folder used for automatic database backups.</summary>
    Public Shared ReadOnly Property BackupFolder As String = Path.Combine(DataRoot, "backups")

    ''' <summary>OpenCV Haar cascade copied next to the executable (Data\*.xml).</summary>
    Public Shared ReadOnly Property CascadeFile As String =
        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "haarcascade_frontalface_default.xml")

    ''' <summary>Creates every folder the application needs. Called once at startup.</summary>
    Public Shared Sub EnsureFolders()
        Directory.CreateDirectory(DataRoot)
        Directory.CreateDirectory(PhotosFolder)
        Directory.CreateDirectory(BackupFolder)
    End Sub

    ''' <summary>Stores a citizen photograph under the photos folder and returns the full path.</summary>
    Public Shared Function StorePhoto(sourceFile As String, cnic As String) As String
        EnsureFolders()
        Dim ext As String = Path.GetExtension(sourceFile)
        If String.IsNullOrEmpty(ext) Then ext = ".jpg"
        Dim safeCnic As String = cnic.Replace("-"c, "")
        Dim target As String = Path.Combine(PhotosFolder, safeCnic & "_" & Format(Now, "yyyyMMdd_HHmmss") & ext)
        File.Copy(sourceFile, target, True)
        Return target
    End Function

End Class
