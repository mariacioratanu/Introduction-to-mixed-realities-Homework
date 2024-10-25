# ✏️🎀Introduction-to-mixed-realities

- this is a repository for a collaborative homework made by Ciorâțanu Maria and Pâncă Aida-Gabriela, year III, group A5, Faculty of Computer Science Iași.
- the homework presented is part of the evaluation in the ”Introduction to mixed realities” subject. 
### 📌Demo lab 1: https://youtube.com/shorts/Ttmk4akJQL4?feature=share
### 📌Demo lab 2: https://youtu.be/ui2TboxFp3Y
### 📌Demo lab 3 in Blender: https://youtu.be/7you8gHTvMM
### 📌Demo lab 3 in Unity:

### 👥Authors:

- Ciorâțanu Maria (3A5)
- Pâncă Aida-Gabriela (3A5)

### 📋Lab 1 2024-2025
- acest proiect implementează o experiență AR folosind Unity și Vuforia, în care două personaje animate își schimbă animațiile pe baza distanței dintre ele.
* am încărcat un screen recording cu personajele și cele două image trackers după ce am realizat build-ul pe Android, pentru a demonstra cum acestea își schimbă animațiile
* am încărcat poze cu rezultatul final al primei teme
  
Pașii pe care i-am urmat:

* am configurat un proiect în Unity 2022.3 LTS cu Vuforia pentru a plasa personaje 3D pe două imagini printate și pentru a urmări distanța dintre ele.
* am creat un Animator Controller pentru a seta animațiile Idle și Attack și am configurat tranzițiile între stări.
* am scris un script C# care detectează distanța dintre personaje și schimbă animațiile de la Idle la Attack atunci când distanța scade sub 0.25 metri.

### 📋Lab 2 2024-2025
- în acest laborator, am implementat o experiență de tip minigolf VR folosind OpenXR și XR Interaction Toolkit.
- am încărcat poze cu rezultatul final
- am încărcat un screen recording cu experiența VR de minigolf testată în Unity fără ajutorul unui Headset, am prezentat toate funcționalitățile, cum arată, cum se poate juca etc.

Pașii pe care i-am urmat:

* am configurat proiectul Unity cu OpenXR și XR Interaction Toolkit, urmând pașii pentru setup-ul complet.
* am configurat XR Device Simulator pentru a testa experiența fără un headset VR.
* am creat un teren de minigolf unde mingea este lovită de o crosă. Am adăugat sistemul de grab pentru a apuca crosa (și mingea) dar și cel de Hit pentru a lovi mingea. 
* am implementat un sistem de scor care contorizează numărul de lovituri și calculează scorul (5 puncte per lovitură).
* am adăugat efecte vizuale (Particle Sistem la lovirea mingii cu crosa, un teren de minigolf complex cu elemente decorative) și o „gaură” de minigolf (adică un Socket Interactor)
* evenimentele sunt semnalate vizual pe un panou UI, unde este afișat numărul de lovituri și scorul.

### 📋Lab 3 2024-2025
- acest proiect modelează o mână 3D în Blender
- în acest laborator, am creat un model 3D al unei mâini în Blender și l-am integrat într-o experiență VR în Unity (cea de la laboratorul 2)

Pașii pe care i-am urmat:

* am modelat o mână 3D cu 5 degete în Blender.
* am realizat UV unwrapping corect pentru texturare fără distorsiuni (nu exista overlapped UV islands) și am aplicat un skin material de pe Blenderkit.
* am exportat modelul ca FBX și l-am importat în Unity.
* am atașat mâinile modelate la controllerele din scenă, folosind Unity XR Toolkit.
* am realizat o animație pentru acțiunea de grab în Blender.

