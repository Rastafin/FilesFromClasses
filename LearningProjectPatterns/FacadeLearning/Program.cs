using FacadeLearning;

Podsystem1 podsystem1 = new Podsystem1();
Podsystem2 podsystem2 = new Podsystem2();
Fasada fasada = new Fasada(podsystem1, podsystem2);

Klient.WywolajFasade(fasada);