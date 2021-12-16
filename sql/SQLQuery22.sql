CREATE TRIGGER del_qianyg_总学分  ON  qianyg_学生成绩
FOR  INSERT,UPDATE
AS
    update qianyg_学生
    set qyg_已修学分=(
                    select sum(qyg_学分) 
                    from qianyg_课程
                    where qyg_课程编号 in (
                                    select qyg_课程编号
                                    from qianyg_学生成绩
                                    where qianyg_学生成绩.qyg_成绩>=60
                                          and qianyg_学生成绩.qyg_学号 in(
                                                                     select qyg_学号
                                                                     from deleted 
                                                                    )
                                  )
                      )
    where qianyg_学生.qyg_学号 in (
                                select qyg_学号  
                                from deleted
                                )
