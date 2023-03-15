using System.ComponentModel;

namespace Escola.Enums
{
    public enum PeriodoMatricula
    {
        
        [Description("Matutino")]
        Basico = 'M',
        [Description("Vespertino")]
        Intermediario = 'V',
        [Description("Noturno")]
        Avançado = 'N'
    }
}
