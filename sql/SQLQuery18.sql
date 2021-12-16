CREATE TRIGGER upd_qianyg_课程类型 ON  qianyg_课程
FOR  INSERT,UPDATE
AS
    IF(SELECT qyg_课程类型 FROM INSERTED)!='考试' and (SELECT qyg_课程类型 FROM INSERTED)!='考察'
    ROLLBACK  TRANSACTION
