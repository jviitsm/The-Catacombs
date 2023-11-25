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
            new Room("Você está em uma sala iluminada por tochas. Um corredor se estende à sua esquerda."),
            new Room("Esta sala está cheia de espelhos. Sua própria reflexão parece te observar."),
            new Room("Você encontrou uma sala com paredes cobertas de musgo. O chão está escorregadio."),
            new Room("Uma sala com uma fonte mágica que brilha em várias cores."),
            new Room("Você entrou em uma sala de treinamento abandonada. Equipamentos quebrados estão por toda parte."),
            new Room("Esta sala tem uma atmosfera misteriosa. Você sente um arrepio na espinha."),
            new Room("Você descobriu uma sala de banquetes vazia. As cadeiras estão viradas de cabeça para baixo."),
            new Room("Uma sala com livros empoeirados e estantes quebradas. Pode haver conhecimento escondido aqui."),
            new Room("Você está em uma sala de música abandonada. Um piano quebrado está no canto."),
            new Room("Uma sala com enormes cristais no teto que emitem uma luz suave."),
            new Room("Você entrou em uma sala de alquimia. Frascos contendo substâncias estranhas estão nas prateleiras."),
            new Room("Uma sala cheia de pinturas mágicas. As imagens parecem se mover."),
            new Room("Você está em uma sala de armadilhas. Preste atenção no chão!"),
            new Room("Esta sala parece um jardim subterrâneo. Flores exóticas estão em plena floração."),
            new Room("Uma sala com inscrições antigas nas paredes. Pode haver segredos a serem decifrados."),
            new Room("Você encontrou uma sala de tesouros vazia. Onde estão os saques escondidos?"),
            new Room("Esta sala parece estar em constante mudança. As paredes estão se transformando lentamente."),
            new Room("Uma sala com uma piscina de água clara. Algo se move sob a superfície."),
            new Room("Você entrou em uma sala com estátuas de pedra. Elas parecem seguir seus movimentos."),
            new Room("Uma sala cheia de borboletas mágicas. Elas brilham em cores vivas."),
            new Room("Você está em uma sala de cristal. A luz se refrata, criando arco-íris."),
            new Room("Uma sala escura com fogueiras verdes que iluminam o caminho."),
            new Room("Você encontrou uma sala de contemplação. Um altar antigo está no centro."),
            new Room("Esta sala parece ser um antigo local de rituais. Marcas estranhas estão desenhadas no chão."),
            new Room("Uma sala com uma porta dourada. O que estará além?"),
            new Room("Você entrou em uma sala de troféus. Cabeças de criaturas estão penduradas nas paredes."),
            new Room("Uma sala com um poço profundo. Você ouve um som distante vindo de dentro."),
            new Room("Você está em uma sala de ilusões. As paredes parecem se contorcer."),
            new Room("Uma sala com um enorme relógio de areia. O tempo está se esgotando."),
            new Room("Esta sala parece ser um escritório abandonado. Papéis estão espalhados por toda parte."),
            new Room("Você encontrou uma sala com um portal mágico. O que acontecerá se você entrar?"),
            new Room("Uma sala com uma fonte de água curativa. Beba com cuidado."),
            new Room("Você está em uma sala com uma escultura gigante. Ela parece observar cada movimento seu."),
            new Room("Uma sala com uma janela que revela o céu estrelado. Você se pergunta como isso é possível."),
            new Room("Você entrou em uma sala com escadas que descem ainda mais. Aonde levarão?"),
            new Room("Esta sala parece ser um antigo laboratório alquímico. Frascos borbulham com substâncias estranhas."),
            new Room("Uma sala com escrituras antigas. Elas contam a história do lugar."),
            new Room("Você encontrou uma sala de treinamento mágica. Poderes misteriosos permeiam o ar."),
            new Room("Uma sala com uma grande árvore no centro. Suas raízes se estendem por todo o chão."),
            new Room("Você está em uma sala de vidro. Criaturas marinhas mágicas nadam fora das paredes."),
            new Room("Uma sala com uma mesa posta. Parece que alguém estava prestes a fazer uma refeição."),
            new Room("Você entrou em uma sala de espelhos infinitos. A reflexão parece se perder no horizonte."),
            new Room("Esta sala parece ser um observatório. Um telescópio aponta para o desconhecido."),
            new Room("Uma sala com uma fonte de lava. O calor é quase insuportável."),
            new Room("Você encontrou uma sala com uma máquina estranha. O propósito dela é desconhecido."),
            new Room("Uma sala com uma piscina de líquido prateado. Reflete imagens do passado e do futuro."),
            new Room("Você está em uma sala com pilares gigantes. Parece um local sagrado."),
            new Room("Uma sala com um portal interdimensional. A passagem para outros mundos está aberta."),
            new Room("Você entrou em uma sala com um enorme baú. Tesouros inimagináveis podem estar dentro."),
            new Room("Esta sala parece ser uma biblioteca mágica. Os livros sussurram conhecimentos arcanos."),
            new Room("Uma sala com uma estátua de um antigo herói. Seus olhos parecem seguir você.")

        };
        }

        public Room GetRandomRoom()
        {
            return rooms[random.Next(rooms.Count)];
        }


    }
}