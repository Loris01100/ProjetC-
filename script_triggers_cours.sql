-- Trigger pour INSERT
CREATE OR REPLACE FUNCTION log_cours_insert() RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO logs (nomTable, TypeOpe, DetailOpe)
    VALUES ('cours', 'INSERT', 'ID: ' || NEW.idcours || ', Libelle: ' || NEW.libellecours);
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER cours_after_insert AFTER INSERT ON cours
FOR EACH ROW EXECUTE PROCEDURE log_cours_insert();

-- Trigger pour UPDATE
CREATE OR REPLACE FUNCTION log_cours_update() RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO logs (nomTable, TypeOpe, DetailOpe)
    VALUES ('cours', 'UPDATE', 'ID: ' || NEW.idcours || ', Old Libelle: ' || OLD.libellecours || ', New Libelle: ' || NEW.libellecours);
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER cours_after_update AFTER UPDATE ON cours
FOR EACH ROW EXECUTE PROCEDURE log_cours_update();

-- Trigger pour DELETE
CREATE OR REPLACE FUNCTION log_cours_delete() RETURNS TRIGGER AS $$
BEGIN
    INSERT INTO logs (nomTable, TypeOpe, DetailOpe)
    VALUES ('cours', 'DELETE', 'ID: ' || OLD.idcours || ', Libelle: ' || OLD.libellecours);
    RETURN OLD;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER cours_after_delete AFTER DELETE ON cours
FOR EACH ROW EXECUTE PROCEDURE log_cours_delete();