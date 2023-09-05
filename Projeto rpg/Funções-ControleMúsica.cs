using NAudio.Wave;

namespace Projeto_rpg
{
    public class ControleMúsica // Corrigir fato de só poder tocar trilha uma vez antes do Stop
    {
        public void Efeito_Sonoro(int n)
        {
            WaveOutEvent Effect_Player;
            AudioFileReader Effect_Reader;

            Effect_Player = new WaveOutEvent();
            Effect_Reader = new AudioFileReader("Colocar som vazio"); // Colocar som vazio aqui

            switch (n)
            {
                case 1:
                    Effect_Reader = new AudioFileReader(" <Colocar efeito sonoro 1 aqui> "); // Colocar ainda
                    break;
                case 2:
                    Effect_Reader = new AudioFileReader(" <Colocar efeito sonoro 2 aqui> "); // Colocar ainda
                    break;
            }

            Effect_Player.Init(Effect_Reader);
            Effect_Player.Play();
        }

        public static string CaminhoTrilha(int n) // Colocar certinho os caminhos, testar, e colocar mais trilhas
        {
            string temp = Directory.GetCurrentDirectory();
            switch (n)
            {
                case 0:
                    // return ($@"{temp}/Soundtrack/Main Sound.mp3"); // Padrão
                    return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Casa
                    // return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Senac
                case 1:
                    // return ($@"{temp}/Soundtrack/Calling Sound.mp3"); // Padrão
                    return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Calling Sound.mp3"); // Casa
                    // return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Calling Sound.mp3"); // Senac
                case 2:
                    // return ($@"{temp}/Soundtrack/Call1 Sound.mp3"); // Padrão
                    return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Call1 Sound.mp3"); // Casa
                    // return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Call1 Sound.mp3"); // Senac
                default:
                    // return ($@"{temp}/Soundtrack/Main Sound.mp3"); // Padrão
                    return (@"C:\Users\Ariel\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Casa
                    // return (@"C:\Users\ariel.asilva2\Source\Repos\Um-Dia-Negro-RPG\Projeto rpg\Soundtrack\Main Sound.mp3"); // Senac
            }
        }

        // GUIA DE SOUNDTRACKS

        // 0: SOM DECHUVA
        // 1: SOM DE LIGAÇÃO (CHAMANDO)
        // 2: SOM DO CONTATO DESCONHECIDO

        public class Soundtrack0
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(0));
        }
        public class Soundtrack1
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(1));
        }
        public class Soundtrack2
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(2));
        }
    }
}
