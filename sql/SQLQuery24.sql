CREATE PROCEDURE 课程分配
@课程编号  char(20)
AS
   SET  NOCOUNT  ON
   DECLARE  @nCount  int  SET  @nCount=0
   SELECT  @nCount=COUNT(qyg_课程编号)  FROM  qianyg_课程 WHERE  qianyg_课程.qyg_课程编号=@课程编号
   IF  @nCount<1
   BEGIN
     PRINT '课程基本信息表中不存在此学号，请检查后重新输入'
     RETURN
   END
