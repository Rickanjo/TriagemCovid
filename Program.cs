Console.WriteLine("=-= Triagem para Covid-19 =-=\n");

Console.WriteLine("Bem-vindo(a) à triagem para COVID-19. Por favor, responda às perguntas abaixo: \n7");

Console.Write("Qual é a idade do paciente? ");
int idade = Convert.ToInt32(Console.ReadLine());

Console.Write("O paciente apresenta febre? [S]im ou [N]ão: ");
bool temFebre = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente apresenta tosse? [S]im ou [N]ão: ");
bool temTosse = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente apresenta falta de ar? [S]im ou [N]ão: ");
bool temFaltaDeAr = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente apresenta aumento de frequência respiratória? [S]im ou [N]ão: ");
bool temAumentoFrequenciaRespiratoria = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente apresenta dor torácica? [S]im ou [N]ão: ");
bool temDorToracica = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente apresenta sensação de desmaio? [S]im ou [N]ão: ");
bool temSensacaoDesmaio = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente possui hipertensão arterial sistêmica? [S]im ou [N]ão: ");
bool temHipertensao = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente possui diabetes melito? [S]im ou [N]ão: ");
bool temDiabetes = Console.ReadLine()!.ToUpper() == "S";

Console.Write("O paciente possui outras doenças crônicas? [S]im ou [N]ão: ");
bool temDoencasCronicas = Console.ReadLine()!.ToUpper() == "S";

Console.WriteLine();


bool encaminharSaude = false; 
bool encaminharAmbulancia = false;
bool isolamentoDomiciliar = false;

if (!temFebre && !temTosse) {
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Nenhuma recomendação específica.");
} else {
    if (temFaltaDeAr || temAumentoFrequenciaRespiratoria || temDorToracica || temSensacaoDesmaio) {
    encaminharAmbulancia = true;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Encaminhar ambulância para o local.");
    } else {
    if ((idade < 18 && (temHipertensao || temDiabetes || temDoencasCronicas)) ||
        (idade >= 18 && (idade >= 65 || temHipertensao || temDoencasCronicas || temAumentoFrequenciaRespiratoria))) {
        encaminharSaude = true;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Encaminhar para o sistema de saúde.");
    } else {
        isolamentoDomiciliar = true;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Recomendar isolamento domiciliar.");
    }
    }
}    
Console.ResetColor();