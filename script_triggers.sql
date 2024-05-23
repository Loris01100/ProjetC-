-- Trigger pour INSERT
CREATE OR REPLACE FUNCTION log_etudiant_insert() RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO logs (nomTable, TypeOpe, DetailOpe)
    VALUES ('etudiant', 'INSERT', 'ID: ' || NEW.idetudiant || ', Nom: ' || NEW.nomEtudiant || ', Prenom: ' || NEW.prenomEtudiant);
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER etudiant_after_insert AFTER INSERT ON etudiant
FOR EACH ROW EXECUTE PROCEDURE log_etudiant_insert();

-- Trigger pour UPDATE
CREATE OR REPLACE FUNCTION log_etudiant_update() RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO logs (nomTable, TypeOpe, DetailOpe)
    VALUES ('etudiant', 'UPDATE', 'ID: ' || NEW.idetudiant || ', Old Nom: ' || OLD.nomEtudiant || ', New Nom: ' || NEW.nomEtudiant);
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER etudiant_after_update AFTER UPDATE ON etudiant
FOR EACH ROW EXECUTE PROCEDURE log_etudiant_update();

-- Trigger pour DELETE
CREATE OR REPLACE FUNCTION log_etudiant_delete() RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO logs (nomTable, TypeOpe, DetailOpe)
    VALUES ('etudiant', 'DELETE', 'ID: ' || OLD.idetudiant || ', Nom: ' || OLD.nomEtudiant);
    RETURN OLD;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER etudiant_after_delete AFTER DELETE ON etudiant
FOR EACH ROW EXECUTE PROCEDURE log_etudiant_delete();