Projektem funkciói

A projektem alapvető célja a programba beolvasott könyveknek véletlenszerű akciókkal való ellátása és azoknak kiexportálása igény szerint. A programra egy április elsejei akciózás keretében lenne szükség, ahol bizonyos könyvekre 10/20/30/40/50 %-os kedvezményt nyújtunk. (A Sale gomb megnyomásával a random szám generálása és az akciózás többször is megvalósítható.) Az XML nem kerül módosításra, mert az akciós ár csak egy napig érvényes.
A programban lehetőség van új könyv felvitelére (szerző, cím, műfaj, ár, publikálás dátuma megadásával - bookid magától generálódik). A felvitelnél megvizsgálom, hogy a felhasználó formailag érvényes szerző nevet, címet, árat, műfajt és dátumot ad-e meg. A vizsgálatok regex felhasználásával történik. A validációs metódusok közül a dátumra és az árra teszteltem többféle tesztadattal. 
Kiegészítésként a valós idő megjelenítéséhez használtam timert. 

Az alábbi tételeket kell kötelezően megvalósítanom:
	Adatok importálása
C) XML feldolgozás (fájlból, vagy webszolgáltatásból)
	Adatfeldolgozás
D) Unit Test megvalósítása egy nem referencia típusú visszatérési értékkel (pl.: int, string, bool stb.) rendelkező függvényhez (legalább 3 teszteset)
	Adatok exportálása / megjelenítése
A) Írás CSV fájlba
	Általános elemek
A) Véletlenszám generálás és felhasználás

	XML:
Az XML-t fájlból importálom, melyhez az adatot itt találtam: https://docs.microsoft.com/en-us/previous-versions/windows/desktop/ms762271(v=vs.85)
Ezt szerializáció segítségével oldottam meg. Ezt a megoldást egy videóban láttam és megtetszett ez a fajta egyszerű megvalósítási, megközelítési mód, mivel a xml-ben tárolt elemeket a megfelelő függvény meghívása után egy List<Book> objektumból el tudtam érni.
	Véletlenszám:
Véletlenszám generálással választom ki azokat a könyveket, melyre kedvezményt adok (április elsejei tréfa). Minden könyvhöz hozzárendelek egy számot (1-10) és ha a szám kisebb vagy egyenlő mint 5 akkor nem adok kedvezményt, ha 6 akkor 10% kedvezményt, ha 7 akkor 20% kedvezményt, ha 8 akkor 30% kedvezményt, ha 9 akkor 40% kedvezményt, ha pedig 10 akkor 50% kedvezményt nyújtok. 
A régi árat megváltoztatom erre az új akciós árra. Az akciózás többször is megvalósítható. 
	Írás CSV fájlba:
CSV fájlba a beolvasott, esetleg módosított (akciós ár, új könyv felvitel) könyvek listáját lehet kiíratni.
	Unit Test:
- Akciós ár számítására
- Exportáláskor a CSV fájl valóban létrejön-e
- Validációs metódusokra (ár, dátum)


