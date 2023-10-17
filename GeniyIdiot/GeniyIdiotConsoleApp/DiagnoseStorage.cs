public class DiagnoseStorage
{
    public List<Diagnose> Diagnoses;


    public static string GetDiagnose(List<Diagnose> diagnoses, int percent)
    {
        return diagnoses[percent / 20].DiagnoseName;

    }
}