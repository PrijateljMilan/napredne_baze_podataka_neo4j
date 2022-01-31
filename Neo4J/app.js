import express from 'express'
require('dotenv').config()

import user from './src/routes/user'

const app = express()
app.use(express.json())
app.use(express.urlencoded({extended:true}))
app.use('/', user)

app.listen(process.env.PORT)