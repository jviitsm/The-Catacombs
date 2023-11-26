using TheCatacombs.Entities;

namespace TheCatacombs.Services
{
    public class RoomManager
    {
        private List<Room> rooms;
        private Random random;

        public RoomManager()
        {
            random = new Random();
            InitializeRooms();
        }

        private void InitializeRooms()
        {
            rooms = new List<Room>
        {
            Room.Factory.Create("Você está em uma sala iluminada por tochas. Um corredor se estende à sua esquerda."),
            Room.Factory.Create("Esta sala está cheia de espelhos. Sua própria reflexão parece te observar."),
            Room.Factory.Create("Você encontrou uma sala com paredes cobertas de musgo. O chão está escorregadio."),
            Room.Factory.Create("Uma sala com uma fonte mágica que brilha em várias cores."),
            Room.Factory.Create("Você entrou em uma sala de treinamento abandonada. Equipamentos quebrados estão por toda parte."),
            Room.Factory.Create("Esta sala tem uma atmosfera misteriosa. Você sente um arrepio na espinha."),
            Room.Factory.Create("Você descobriu uma sala de banquetes vazia. As cadeiras estão viradas de cabeça para baixo."),
            Room.Factory.Create("Uma sala com livros empoeirados e estantes quebradas. Pode haver conhecimento escondido aqui."),
            Room.Factory.Create("Você está em uma sala de música abandonada. Um piano quebrado está no canto."),
            Room.Factory.Create("Uma sala com enormes cristais no teto que emitem uma luz suave."),
            Room.Factory.Create("Você entrou em uma sala de alquimia. Frascos contendo substâncias estranhas estão nas prateleiras."),
            Room.Factory.Create("Uma sala cheia de pinturas mágicas. As imagens parecem se mover."),
            Room.Factory.Create("Você está em uma sala de armadilhas. Preste atenção no chão!"),
            Room.Factory.Create("Esta sala parece um jardim subterrâneo. Flores exóticas estão em plena floração."),
            Room.Factory.Create("Uma sala com inscrições antigas nas paredes. Pode haver segredos a serem decifrados."),
            Room.Factory.Create("Você encontrou uma sala de tesouros vazia. Onde estão os saques escondidos?"),
            Room.Factory.Create("Esta sala parece estar em constante mudança. As paredes estão se transformando lentamente."),
            Room.Factory.Create("Uma sala com uma piscina de água clara. Algo se move sob a superfície."),
            Room.Factory.Create("Você entrou em uma sala com estátuas de pedra. Elas parecem seguir seus movimentos."),
            Room.Factory.Create("Uma sala cheia de borboletas mágicas. Elas brilham em cores vivas."),
            Room.Factory.Create("Você está em uma sala de cristal. A luz se refrata, criando arco-íris."),
            Room.Factory.Create("Uma sala escura com fogueiras verdes que iluminam o caminho."),
            Room.Factory.Create("Você encontrou uma sala de contemplação. Um altar antigo está no centro."),
            Room.Factory.Create("Esta sala parece ser um antigo local de rituais. Marcas estranhas estão desenhadas no chão."),
            Room.Factory.Create("Uma sala com uma porta dourada. O que estará além?"),
            Room.Factory.Create("Você entrou em uma sala de troféus. Cabeças de criaturas estão penduradas nas paredes."),
            Room.Factory.Create("Uma sala com um poço profundo. Você ouve um som distante vindo de dentro."),
            Room.Factory.Create("Você está em uma sala de ilusões. As paredes parecem se contorcer."),
            Room.Factory.Create("Uma sala com um enorme relógio de areia. O tempo está se esgotando."),
            Room.Factory.Create("Esta sala parece ser um escritório abandonado. Papéis estão espalhados por toda parte."),
            Room.Factory.Create("Você encontrou uma sala com um portal mágico. O que acontecerá se você entrar?"),
            Room.Factory.Create("Uma sala com uma fonte de água curativa. Beba com cuidado."),
            Room.Factory.Create("Você está em uma sala com uma escultura gigante. Ela parece observar cada movimento seu."),
            Room.Factory.Create("Uma sala com uma janela que revela o céu estrelado. Você se pergunta como isso é possível."),
            Room.Factory.Create("Você entrou em uma sala com escadas que descem ainda mais. Aonde levarão?"),
            Room.Factory.Create("Esta sala parece ser um antigo laboratório alquímico. Frascos borbulham com substâncias estranhas."),
            Room.Factory.Create("Uma sala com escrituras antigas. Elas contam a história do lugar."),
            Room.Factory.Create("Você encontrou uma sala de treinamento mágica. Poderes misteriosos permeiam o ar."),
            Room.Factory.Create("Uma sala com uma grande árvore no centro. Suas raízes se estendem por todo o chão."),
            Room.Factory.Create("Você está em uma sala de vidro. Criaturas marinhas mágicas nadam fora das paredes."),
            Room.Factory.Create("Uma sala com uma mesa posta. Parece que alguém estava prestes a fazer uma refeição."),
            Room.Factory.Create("Você entrou em uma sala de espelhos infinitos. A reflexão parece se perder no horizonte."),
            Room.Factory.Create("Esta sala parece ser um observatório. Um telescópio aponta para o desconhecido."),
            Room.Factory.Create("Uma sala com uma fonte de lava. O calor é quase insuportável."),
            Room.Factory.Create("Você encontrou uma sala com uma máquina estranha. O propósito dela é desconhecido."),
            Room.Factory.Create("Uma sala com uma piscina de líquido prateado. Reflete imagens do passado e do futuro."),
            Room.Factory.Create("Você está em uma sala com pilares gigantes. Parece um local sagrado."),
            Room.Factory.Create("Uma sala com um portal interdimensional. A passagem para outros mundos está aberta."),
            Room.Factory.Create("Você entrou em uma sala com um enorme baú. Tesouros inimagináveis podem estar dentro."),
            Room.Factory.Create("Esta sala parece ser uma biblioteca mágica. Os livros sussurram conhecimentos arcanos."),
            Room.Factory.Create("Uma sala com uma estátua de um antigo herói. Seus olhos parecem seguir você.")

        };
        }

        public Room GetRandomRoom()
        {
            return rooms[random.Next(rooms.Count)];
        }


    }
}