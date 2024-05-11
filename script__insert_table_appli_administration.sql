insert into utilisateur (loginutilisateur, mdputilisateur) values ('Magali','mgo');

insert into section (libelleSection) values ('Licence développeur et infrastructure'), ('Management de projet '), ('CSI'), ('MS2D');

insert into etudiant (nomEtudiant, prenometudiant, idSection, adresse) values 
('Singier','Romain',1, 'Jean Macé'),
('Dupont','Remy',1, 'Jean Moulin'),
('Castre','Alexandra',1, 'Villeurbane'),
('Hazaki','Tokyo',2, 'Confluence'),
('Fournil','Dimitri',2, 'Montchat');

insert into cours (libelleCours, descriptionCours, idSection) values 
('React','Framework JS', 1),
('Communication','Communication', 2),
('Symphony','Framework PHP', 2),
('Python','Python', 1);