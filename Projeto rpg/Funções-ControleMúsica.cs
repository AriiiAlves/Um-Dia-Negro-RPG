using NAudio.Wave;

namespace Projeto_rpg
{
    public class ControleMúsica
    {
        public static string CaminhoTrilha(int n)
        {
            string temp = Directory.GetCurrentDirectory();
            switch (n)
            {
                case 0:
                    return ($@"{temp}/Soundtrack/Som de chuva.mp3");
                case 1:
                     return ($@"{temp}/Soundtrack/Chamando.mp3");
                case 2:
                     return ($@"{temp}/Soundtrack/Desconhecido.mp3");
                case 3:
                    return ($@"{temp}/Soundtrack/Rafael Brother.mp3");
                case 4:
                    return ($@"{temp}/Soundtrack/Rafael Brother Caixa Postal.mp3");
                case 5:
                    return ($@"{temp}/Soundtrack/Thomas.mp3");
                case 6:
                    return ($@"{temp}/Soundtrack/CSP.mp3");
                case 7:
                    return ($@"{temp}/Soundtrack/Sofia.mp3");
                default:
                     return ($@"{temp}/Soundtrack/Som de chuva.mp3");
            }
        }

        // GUIA DE SOUNDTRACKS

        // 0: SOM DECHUVA
        // 1: SOM DE LIGAÇÃO (CHAMANDO)
        // 2: SOM DO CONTATO DESCONHECIDO
        // 3: SOM DO RAFAEL BROTHER
        // 4: SOM DO RAFAEL BROTHER CAIXA POSTAL
        // 5: SOM DO THOMAS
        // 6: SOM DO CSP
        // 7: SOM DA SOFIA

        public class Soundtrack0
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(0));
        }
        public static void Conferir_Trilha_de_Fundo() // Gambiarra: mantém o loop na força bruta
        {
            if(Soundtrack0.Player.PlaybackState != PlaybackState.Playing)
            {
                Soundtrack0.Player.Dispose();
                Soundtrack0.Leitor.Dispose();
                Soundtrack0.Leitor = new AudioFileReader(CaminhoTrilha(0));
                Soundtrack0.Player.Init(Soundtrack0.Leitor);
                Soundtrack0.Player.Play();
                Soundtrack0.Player.Volume = 0.5f;
            }
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
        public class Soundtrack3
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(3));
        }
        public class Soundtrack4
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(4));
        }
        public class Soundtrack5
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(5));
        }
        public class Soundtrack6
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(6));
        }
        public class Soundtrack7
        {
            public static WaveOutEvent Player = new WaveOutEvent();
            public static AudioFileReader Leitor = new AudioFileReader(CaminhoTrilha(7));
        }
    }
}
