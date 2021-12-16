create view qianyg_学生成绩视图(学号,姓名,专业,学期,成绩,教师姓名,课程名称)
as
select  distinct qianyg_学生.qyg_学号,qianyg_学生.qyg_姓名,qianyg_班级.qyg_专业,
          qianyg_学生成绩.qyg_学期,qianyg_学生成绩.qyg_成绩,
          qianyg_教师.qyg_姓名,qianyg_课程.qyg_课程名称
  from qianyg_学生成绩,qianyg_学生,qianyg_班级,qianyg_课程,qianyg_教授课程,qianyg_教师
  where qianyg_学生成绩.qyg_学号=qianyg_学生.qyg_学号
        and qianyg_学生.qyg_班级编号=qianyg_班级.qyg_班级编号
        and qianyg_学生成绩.qyg_课程编号=qianyg_课程.qyg_课程编号
        and qianyg_学生成绩.qyg_教师编号=qianyg_教师.qyg_教师编号
