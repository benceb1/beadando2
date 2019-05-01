Dj. Knuth esküvőkre készít zene összeállításokat. Szüksége van egy programra, 
ami megadott igényeknek megfelelően elkészít egy optimális válogatást.
A program működése legyen független a konkrét tartalmaktól, bármilyen ILejátszható
interfészt megvalósító osztályt tudjon kezelni, ami

   tartalmaz egy SzerzőiJogdíj tulajdonságot (szám lejátszásonként ennyit kell fizetni)
   és Hossz tulajdonságot,
   illetve egy Stílus tulajdonságot (ami az alábbi értékeket veheti fel: „Családias” „Mulatós” „Romantikus” „Nyálas” stb.).
Készítsen el néhány osztályt (ehhez építsen ki egy célszerű osztályhierarchiát),
amelyek megvalósítják ezt az interfészt, és ezekből hozzon létre mintapéldányokat:

   pl. Film (cím: gyerekkori nagyon vicces események, ár: 0, hossz: 0,5 óra, stílus: családi)
   pl. VásároltZene (cím: Pataki Attila – Jegenyefák, ár: 20Ft, hossz: 4 perc, stílus: mulatós)
   pl. TorrentZene (cím: Iron Maiden – Number of the beast, hossz: 2 perc, stílus: romantikus)
   stb.
  
Ezt követően készítsen egy tartalom összeállító rendszert, amely az alábbi funkciókkal rendelkezik:

  1. Fel lehet tölteni ILejátszható interfészt megvalósító elemekkel. Mivel meglehetősen sok ilyenre számítunk,
  ezeket tároljuk el egy rendezett láncolt listában, ahol a rendezés szempontja legyen a Stílus tulajdonság.
  Legyen lehetőség elemek törlésére is.
  
  2. A gyorsabb keresés érdekében egy külső táblázat tartalmazzon referenciákat az egyes stílus csoportok első elemére.
  3. Legyen egy optimális tartalom összeállító funkciója, amelynek meg lehet adni, hogy a leendő megrendelők milyen
  stílusokat támogatnak, illetve milyen hosszú műsort szeretnének. A program válogassa le a stílusnak megfelelő tartalmakat,
  majd visszalépéses keresés segítségével állítson össze egy olyan válogatást, ami minél pontosabban lefedi a rendelkezésre
  álló időt (egy elem csak egyszer szerepelhet). Ha több ilyen lehetőség is van, akkor azok közül az összességében legolcsóbbat
  adja meg eredményül.
  
  4. A tartalom összeállító alrendszer egy eseményen keresztül már a keresés közben is mindig jelezze, hogyha talált
  egy, az addig legjobbnak gondoltnál optimálisabb összeállítást.
  
  5. Minden Zene rendelkezzen egy ár változás eseménnyel. Amennyiben ez megtörténik, és a változás befolyásolhatja az
  utolsó keresés eredményét, akkor az hajtódjon újra végre.


A feladat megoldása során tartsa be a tanult OOP alapelveket, kivételkezelés segítségével kezelje 
a felmerülő problémás eseteket. Ahol szükséges, egészítse ki a megadott osztályhierarchiát, 
illetve használja a tanult technikákat (generikus típusok, operátor overloading stb.).
