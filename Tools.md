# Eszközök - JS, C#, SQL

## Visual Studio Code
  - **Zoom:** File > Preferences > Settings > "zoom" (checkbox)
  - **Extensions:**
    - Live Server
    - Material Icon Theme
    - Markdown All in One (Pl.: ctrl + b)
    - Markdown Preview Enhanced (szép megjelenítés)
    - TODO Highlight ("TODO:" és "FIXME:" jelölések)
  - **JS Snippet suggestions:** File > Preferences > Settings > "snippet" (`inline` helyett `top`)
  - **Gyorsgombok:**
    - Komment (toggle): `ctrl+ü`
    - Sorcsere: `alt+⬆️`, `alt+⬇️`
    - Sor másolás: `alt+shift+⬆️`, `alt+shift+⬇️`
    - Sor törlés (kivágás): `shift+del`
    - Kurzor duplikálás: `ctrl+alt+⬆️`, `ctrl+alt+⬇️`
    - Sorok tördelése (word wrap): `ctrl + z`

## Visual Studio
  - **Komment (toggle):** `ctrl + k + ü`
    - helyette: Tools > Options > Environment > Keyboard > ToggleLineComment `ctrl + ü`
  - **Intellisense:** Tools > Options > Text Editor > C# IntelliSense
    - "New snippet experience" ne legyen pipálva
  - **Turn off completions:** Tools > Options > IntelliCode > General
    - "Show whole line completions" ne legyen pipálva
  - **Color theme:** Tools > Options > Environment > General
  - **Sorok tördelése (word wrap):** `ctrl + e + w`

## XAMPP
  - **phpMyAdmin (browser):** `http://localhost/phpmyadmin/`
  - **Hitelesítés:** Apache > Config: `config.inc.php`
    - `$cfg['Servers'][$i]['user'] = 'root';`
    - `$cfg['Servers'][$i]['password'] = '';`
  - **Kapcsolódás cmd-ből:**
    - Szerver legyen elindítva! (Apache + MySQL)
    - `mysql -u root` ha nincs jelszó
    - `mysql -u <userName> -p` majd jelszó beírni
    - `exit` kilépés

