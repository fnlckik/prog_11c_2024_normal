# OOP - beadandó

**Beadni:** `projektnev.zip` fájl

**Határidő:** 06. 01. (éjfél)

---

**Feladat (OOP):** Készítsetek **modell**t egy általatok választott témában az alábbi leírás alapján.

Nem választhattok olyan témát, amit órán csináltunk: diákok, filmek, könyvek.

*Téma ötletek: zenék, videójátékok, szuperhősök, nyaralások, kutyák, számítógépek, cipők, hegyek, stb...*

1. Hozzatok létre egy **osztály**t, és vegyetek fel legalább 4 darab privát **adattag**ot! - **2p**
   	
	Legyen közöttük
	- legalább egy egész
	- legalább egy szöveges
	- legalább egy lebegőpontos vagy logikai vagy dátum
	- legalább egy olyan, amely csoportosításra alkalmas, vagyis **értékkészlete 4-6 elemű**.

	Pl.: a filmek esetén a műfaj csak 4 fajta lehetett, diákoknál a jegyek csak 5 fajta értéket vehettek fel.

2. Legyen az osztályban legalább két különböző paraméterezésű **konstruktor**! - **1p**

3. Készítsetek az adattagokhoz **property**-ket! Legyen az osztályban legalább egy **nem triviális** `getter` és `setter` is! - **2p**
   
   **Nem triviális**: nem az alapértelmezett, vagyis különbözik attól, amit a környezet generálna.
   
   *Pl.: egy `getter` nem közvetlen az adatot adja, hanem neki kerekített értékét, egy `setter` a kapott értéket ellenőrzi.*

4. Egy objektum adatainak értelmes megjelenítéséhez definiáljátok felül az alapértelmezett `ToString()` metódust! - **1p**

5. Tartozzon az osztályhoz legalább még egy olyan **metódus**, amellyel a belső állapot (tagváltozók) értéke módosítható vagy belőlük számolt adat lekérhető! - **2p**

6. Készíts egy másik osztályt, amelyben található egy privát **lista**, amely a másik osztályba tartozó objektumokat képes tárolni! - **1p**

7. Tartozzon a másik osztályhoz egy `FajlbolOlvas(string fajlnev)` nevű metódus, amely beolvassa a paraméterként kapott fáljból az adatokat, majd eltárolja a listában. - **1p**

8. Tudjuk lekérni (általatok választott tulajdonság alapján) a **legnagyobb vagy legkisebb** adatot! A teljes objektumot adja vissza a metódus! - **2p**

9. Tudjuk **rendezni** a tárolt adatokat! A rendezést végző metódusnak paraméterként adhassuk meg, hogy növekvő vagy csökkenő sorrendet kérünk! - **2p**

11. Bővítsétek az osztályt egy `General(string fajlnev)` metódussal, amely a paraméterként kapott néven létrehoz egy fájlt, amelybe véletlenszerűen generált adatokat ír. - **2p**
    
      Legalább kétfajta különböző típusú adatot **véletlenszerűen** generáljatok!

      *Az sem gond, ha mind véletlenszerű, de például filmek címét előkészíthetitek egy fájlban, majd azt beolvasva generálhattok hozzájuk véletlenszerű adatokat.*

12. A `Program.cs` fájlban szemléltesd egy-egy **példá**val az elkészült osztályok **működés**ét! - **2p**

**Összesen:** 18 pont
