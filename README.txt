Projektem funkciói

Az alábbi tételeket kell megvalósítanom:
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
Ezt szerializációval oldottam meg (folyamat, amely objektum példányokat ment a merevlemezre --> objektumok állapotát tárolom, attribútomok értékét fájlban tárolom)

	Véletlenszám:
Véletlenszám generálással választom ki azokat a könyveket melyre kdvezményt adok. Minden könyvhöz hozzárndelek egy számot (1-10) és ha a szám kisebb vagy egyenlő mint 5 akkor nem adok kedvezményt, ha 6 akkor 10% kedvezményt, ha 7 akkor 20% kedvezményt, ha 8 akkor 30% kedvezményt, ha 9 akkor 40% kedvezményt, ha pedig 10 akkor 50% kedvezményt.
A régi árat megváltoztatom erre az új akciós árra.

	Írás CSV fájlba:
A CSV fájlba az új akciós árakkal ellátott könyveket fogom kiíratni.

	Unit Test:
- Árazás számítására
- Fájl (CSV) valóban létrejött-e?



