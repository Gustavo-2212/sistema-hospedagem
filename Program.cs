using Hospedagem.Model;

Suite suitePro = new Suite(tipoSuite: "5 Estrelas"); //10
Suite suiteClasseAlta = new Suite(tipoSuite: "4 Estrelas"); //8
Suite suiteMedia = new Suite(tipoSuite: "3 Estrelas"); //5
Suite suiteComum = new Suite(tipoSuite: "Comum"); //3

List<Pessoa> hospedesPro = new List<Pessoa>(){
    new Pessoa("Gustavo", "Alves de Oliveira"),
    new Pessoa("Joana", "Macedo"),
    new Pessoa("João", "Pé de Feijão"),
    new Pessoa("Lúcia", "Carvalho"),
    new Pessoa("Maria", "Muié do João"),
    new Pessoa("Marta", "Rainha"),
    new Pessoa("Bart", "Simpson"),
    new Pessoa("Lisa", "Simpson"),
    new Pessoa("Margie", "Simpson")
};

List<Pessoa> hospedesClasseAlta = new List<Pessoa>(){
    new Pessoa("Cassandra", "Muié do João"),
    new Pessoa("Marta", "Morgato"),
    new Pessoa("Bartolomeu", "Ferreira Simpson"),
    new Pessoa("Pablo", "Simpson"),
    new Pessoa("Ned", "Flandders"),
    new Pessoa("Dil", "Vane")
};

List<Pessoa> hospedesMedia = new List<Pessoa>(){
    new Pessoa("Carlos", "Homem do João"),
    new Pessoa("Carlito", "Rei"),
    new Pessoa("Bruno", "Simpson"),
    new Pessoa("Bielzin", "Simpson"),
    new Pessoa("Lobato", "Simpson")
};

List<Pessoa> hospedesComum = new List<Pessoa>(){
    new Pessoa("Laura", "Soares"),
    new Pessoa("Larissa", "Pobre"),
    new Pessoa("Gabriel", "Mendigo")
};

// -------------------- MONTANDO A RESERVA -----------
Reserva reservaComum = new Reserva(52);
reservaComum.CadastrarSuite(suiteComum); 
reservaComum.CadastrarHospedes(hospedesComum);


// -------------------- VISUALIZANDO -----------------
Console.WriteLine(reservaComum);
