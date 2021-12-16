CREATE PROCEDURE InsertResult
@学号  char(20)
AS
   SET  NOCOUNT  ON
   DECLARE  @nCount  int  SET  @nCount=0
   SELECT  @nCount=COUNT(qyg_学号)  FROM  qianyg_学生 WHERE  qianyg_学生.qyg_学号=@学号
   IF  @nCount<1
   BEGIN
     PRINT '学生基本信息表中不存在此学号，请检查后重新输入'
     RETURN
   END
