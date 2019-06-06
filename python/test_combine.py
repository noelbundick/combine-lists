people = """1,Sally
2,John
3,Cortana"""

colors ="""2,Green
3,Blue
4,Red"""

expected ="""2,John,Green
3,Cortana,Blue"""

def test_combine_lists():
    result = ""
    assert result == expected
