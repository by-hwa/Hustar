const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => {
  res.send('Hello World!')
})

app.get('/about', (req,res) => {
    res.send('<h1>반가워요</h>')
})

app.get('/index', (req,res) => {
    res.sendFile(__dirname + '/index.html')
})

app.get('/main', (req,res) => {
    res.sendFile(__dirname + '/main.html')
})

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})
