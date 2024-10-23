# RPG - Zadania

1. [Łatwe] Dodać do projektu folder Klasy, w którym będą tworzone wszystkie klasy gry,
2. [Łatwe] Stworzyć klasę Hero, która powinna posiadać własności (Hp - typ całkowity, Nazwa – typ tekstowy, Atak – typ całkowity).
3. [Łatwe] Do klasy Hero dodać konstruktor przyjmujący wartości dla utworzonych własności,
4. [Łatwe] Do klasy Hero dodać metodę WyswietlStatystyki, która powinna wyświetlać na konsolę tekst Postać (Nazwa) posiada (Hp) życia i (Atak) ataku.
5. [Łatwe] Dodać klasę Wojownik, która ma dziedziczyć po klasie Hero. Powinna ona mieć własność Obrona (typ całkowity)
6. [Łatwe] Dodać klasę Mag, która ma dziedziczyć po klasie Hero Powinna ona mieć własność Moc (typ całkowity)
7. [Średnie] Do klas Mag i Wojownik dodać metodę OdejmijHp, która przyjmować ma ilość życia do odjęcia. Jej zadaniem jest zmniejszyć ilość życia o przekazaną wartość. Dodatkowo dla klasy Wojownik ilość życia do odjęcia wyznaczyć na podstawie wzoru: zycieDoOdjecia – (Obrona / 3).
8. [Średnie] Do klas Mag i Wojownik dodać metodę PobierzSileAtaku, jej zadaniem jest zwrócić wartość ataku bohatera. Dodatkowo dla klasy Mag ilość życia do odjęcia wyznaczyć na podstawie wzoru: Atak + (Moc / 5).
9. [Łatwe] Dodać klasę GeneratorPostaci i zaimplementować w niej dwie metody: GenerujMaga oraz GenerujWojownika, które mają zwracać utworzony obiekt maga oraz wojownika
10. [Średnie] W funkcji Main programu dodać kod tworzący maga oraz wojownika za pomocą utworzonego wcześniej generatora (najpierw należy utworzyć obiekt generatora).
11. [Średnie] Dodać kod informujący gracza, że spotkał na swojej drodze wroga (maga) i pozwalający wybrać, czy chce podjąć walkę czy uciekać. W przypadku wyboru ucieczki program powinien się zakończyć.
12. [Średnie] W przypadku podjęcia walki: Stworzyć pętle, która będzie symulować walkę pomiędzy wojownikiem i magiem (Walka powinna trwać, dopóki życie któregoś z graczy nie spadnie poniżej zera)
13. [Trudne] Dodać kod, który po zakończonej walce wyświetli, który gracz zwyciężył
14. [Średnie] Przetestować różne scenariusze walki modyfikując wartość życia, ataku, obrony i mocy postaci.
15. [Trudne] W generatorze postaci dodać listę tekstów i uzupełnić ją domyślnie kilkoma imionami, a następnie zmodyfikować metody tworzące postacie tak, aby za każdym razem losowały imię z listy (wykorzystać klasę Random).
