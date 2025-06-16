# 🧑‍🍳 Style&Cook - Jeu de Cartes Stratégique

**Style&Cook** est un jeu de cartes compétitif en 1v1, prenant place dans l'univers impitoyable mais savoureux de la restauration. Incarnez un restaurateur ambitieux, construisez votre deck, améliorez votre établissement et battez vos rivaux à coups de réputation, d’argent... ou de manigances douteuses.

---

## 📌 Sommaire

- [🎯 Objectif du jeu](#-objectif-du-jeu)
- [🃏 Mécaniques de jeu](#-mécaniques-de-jeu)
- [🏢 Plateau de jeu](#-plateau-de-jeu)
- [📈 Progression & moralité](#-progression--moralité)
- [🎮 Modes de jeu](#-modes-de-jeu)
- [🎨 Style visuel](#-style-visuel)
- [🛠️ Technologies prévues](#️-technologies-prévues)
- [📌 Roadmap MVP](#-roadmap-mvp)
- [📷 Visuels (à venir)](#-visuels-à-venir)

---

## 🎯 Objectif du jeu

Le joueur doit prendre le contrôle d'un établissement de restauration et vaincre son adversaire à travers des décisions économiques, stratégiques ou... moralement discutables.

### Conditions de victoire :
- Atteindre un certain montant d'argent 💰
- Obtenir une étoile (réputation parfaite) ⭐
- Provoquer la **fermeture du restaurant adverse** (banqueroute, scandale, hygiène...)

---

## 🃏 Mécaniques de jeu

- **Jeu en tour par tour** (type Hearthstone)
- **Deckbuilding** avec cartes à bonus/malus
- Pas de combat direct : les cartes influencent économie, réputation, équipements ou adversaire

### Exemples de cartes :
- 🧍‍♂️ *Le Magasinier* → Réduit les frais d’entretien
- 🚓 *Contrôleur d’hygiène* → Fait chuter la fréquentation adverse
- 👨‍🍳 *Chef Célébrité* → Boost temporaire de notoriété

### Rareté des cartes :
- Carte standard
- Carte dorée (version améliorée déblocable après 500-1000 parties)

### Collection & Boosters :
- Les cartes sont obtenues via des **boosters**
- Possibilité d’ajouter des **références à de vrais chefs** ou cuisines du monde

---

## 🏢 Plateau de jeu

Le plateau est une **rue animée en 2D ou isométrique**, séparant les deux établissements.

Chaque joueur possède 3 emplacements :
1. **Établissement principal** (tiré aléatoirement en début de partie, avec bonus unique) :
   - Fast Food → +fréquentation (drive)
   - Pizzeria → point de vente 24h sur plateau adverse
   - Gastronomique → revenus élevés, clientèle exigeante
2. **Structure secondaire** (parking, banque, journal…)
3. **Structure tertiaire** (publicité, agence d’intérim, etc.)

👥 Les clients apparaissent et défilent sur la rue, se dirigeant vers l’un ou l’autre restaurant selon la réputation, les promotions, ou les effets de cartes.

---

## 📈 Progression & moralité

### Arbre de compétence :
- Équipements améliorables : frigo, four, caisse, presse...
- Gagnez des effets passifs en investissant

### Moralité :
- Certaines actions sont *risquées mais avantageuses* :
  - Employés non déclarés
  - Hygiène douteuse
  - Sabotage de l’adversaire
  - Détournement de subventions
- Ces actions peuvent déclencher des **contrôles**, des **scandales**, voire une **fermeture administrative**.

---

## 🎮 Modes de jeu

- **Solo/Campagne** : apprentissage progressif, missions, objectifs
- **Multijoueur** :
  - 1v1 classé (classement mondial)
  - 1v1 non classé (détente)
- Éventuellement : événements spéciaux, bots IA

---

## 🎨 Style visuel

- Graphismes **cartoon / stylisés**, inspirés de *Overcooked*
- Personnages attachants et drôles
- Environnements dynamiques (pluie, coupures de courant, rushs...)
- Ambiance sonore légère et variée selon le type d’établissement

---

## 🛠️ Technologies prévues

> En fonction de la progression en développement

- 🎮 Moteur : **Godot Engine** (GDScript ou C#)
- 📦 Backend (plus tard) : **Node.js** ou **Python Flask** pour le multijoueur
- 💾 Base de données : SQLite ou Firebase pour les decks, comptes joueurs
- 🌐 Cible : PC d’abord, éventuellement mobile

---

## 📌 Roadmap MVP

| Étape | Description | Statut |
|-------|-------------|--------|
| 1 | Écrire le README / GDD de base | ✅ |
| 2 | Créer un schéma du plateau de jeu | 🔄 En cours |
| 3 | Prototyper l’interface de jeu | ⬜ |
| 4 | Ajouter quelques cartes test avec effets simples | ⬜ |
| 5 | Intégrer le système d’argent / réputation | ⬜ |
| 6 | Créer une partie complète en local | ⬜ |
| 7 | Ajouter boosters et collection de cartes | ⬜ |
| 8 | Prototype multijoueur simple | ⬜ |

---

## 📷 Visuels (à venir)

- 🧱 Schéma du plateau de jeu :
- ![046196d6-1e53-4b0c-ac1f-679def7d29a6](https://github.com/user-attachments/assets/e3eb99ac-d944-433d-ada2-6295376e6e5e)
- ![94e75b5b-c703-44c1-827b-bcea17259a49](https://github.com/user-attachments/assets/cce0c393-260f-42bc-ac4b-0887fd25ce37)
- 🃏 Exemples de cartes
- 📊 Arbre de compétences
- 🗺️ Interface utilisateur mockup

---
