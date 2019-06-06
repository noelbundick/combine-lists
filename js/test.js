var assert = require('assert');

const people = `1,Sally
2,John
3,Cortana`

const colors = `2,Green
3,Blue
4,Red`

const expected = `2,John,Green
3,Cortana,Blue`

describe('combine', function() {
  it('should combine lists', function(){
    let result = "";
    assert.equal(result, expected);
  });
});