# Vonatok

Három különálló feladatot kell megoldanod, mindegyik saját eljárásban (`Feladat1`, `Feladat2`, `Feladat3`). A szükséges további függvények nevét a feladatleírásban találod zárójelben.

---

## 1. feladat ⏱

A `vonat.txt` fájlban vonatok késéseiről vannak adatok. Az első sor tartalmazza az adatok mennyiségét. Minden további sorban két adat van: egy vonat végállomásának neve, és az érkezéskor feljegyzett késés mértéke (percben).

- Olvasd be az adatokat a konzolról!
- Használj egy szótárat, hogy minden egyes végállomásra eltárold az eddigi legnagyobb késést.
- A beolvasást és a kiírást külön eljárásokban valósítsd meg! (`Beolvas`, `Kiir`)

*A beolvasott adatok eltárolása nem szükséges, a továbbiakban nem kell velük dolgozni.*

**Minta kimenet:**
```
1. feladat
Szolnok: 8
Budapest: 43
Miskolc: 13
Szeged: 12
Debrecen: 5
```

---

## 2. feladat 🛂

Egy MÁV ellenőr egy nap alatt 5 vonaton ellenőrizte a jegyeket. Minden vonaton legalább 2, de legfeljebb 10 utas kapott büntetést, melynek mértéke 20000 Ft és 50000 Ft közötti, 1000 Ft-ra kerekített érték.

Szimuláld az ellenőr útját. Hozz létre egy mátrixot listák listájaként, amely `i`. sorának `j`. eleme az `i`. út során kiosztott `j`. büntetés értéke.

A mátrixot egy függvény (`Feltolt`) visszatérési értékeként kapjuk meg! Írd ki a mátrix elemeit, valamint a nap során kiosztott büntetések összértékét!

**Minta kimenet:**
```
2. feladat
34000 28000 42000 49000 45000 27000 21000 27000 30000
39000 25000 33000
49000 41000 36000 36000 36000 48000 38000 43000 31000 38000
43000 39000
46000 26000 35000 31000 41000
Összes büntetés: 1057000
```

---

## 3. feladat 🚉

Ismerjük két vonat állomásait:

**Budapest-Cegléd vonal állomásai:**

```cs
"Budapest-Nyugati", "Zugló", "Kőbánya alsó", "Kőbánya-Kispest", "Ferihegy", "Monor", "Monorierdő", "Pilis", "Albertirsa", "Ceglédbercel", "Ceglédbercel-Cserő", "Budai út", "Cegléd"
```

**Budapest-Szeged vonal állomásai:**

```cs
"Budapest-Nyugati", "Zugló", "Kőbánya-Kispest", "Ferihegy", "Cegléd", "Nagykőrös", "Kecskemét", "Kiskunfélegyháza", "Kistelek", "Szatymaz", "Szeged"
```

- Rögzítsd az adatokat két halmazban!

- Írd ki azokat az állomásokat, ahol csak az első vonat áll meg! Ne használd a `ExceptWith` metódust, hanem írj saját függvényt, amely visszatérési értéke a megfelelő állomások halmaza! (`CsakElsoAllomasok`)

- Számold meg, hány olyan állomás van, ahol mindkét vonat megáll! Most is készíts saját függvényt, amely visszatér a közös állomások számával, de azon belül használhatod a halmaz adatszerkezet beépített függvényeit is! (`KozosekSzama`)

- Igaz-e, hogy az első vonat minden állomásán megáll a második vonat is?

**Minta kimenet:**
```
3. feladat
a)
Kőbánya alsó
Monor
Monorierdő
Pilis
Albertirsa
Ceglédbercel
Ceglédbercel-Cserő
Budai út
b) 5
c) False
```
