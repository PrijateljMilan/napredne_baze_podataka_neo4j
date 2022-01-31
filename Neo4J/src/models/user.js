import { nanoid } from 'nanoid';

const neo4j = require('neo4j-driver');
require('dotenv').config()
const {
    url,
    db_username,
    db_password,
    database
} = process.env

const driver = neo4j.driver(url, neo4j.auth.basic(db_username, db_password));
const session = driver.session({database:database});
  
const findAll = async ()=> {
    const result =  await session.run(`MATCH (u:User) return u`)
    return result.records.map(i=>i.get('u').properties)
}
const findById = async (id)=> {
    const result =  await session.run(`MATCH (u:User {_id: '${id}'}) return u limit 1`)
    return result.records[0].get('u').properties
}
const create = async (user)=> {
    const result =  await session.run(`CREATE (u:User {_id: '${nanoid(8)}', name: '${user.name}', cardID: '${user.cardID}', address:'${user.address}'}) return u`)
    return result.records[0].properties
}
const findByIDAndUpdate = async (id, user)=> {
    await session.run(`MATCH (u:User {_id: '${id}'}) SET u.name: '${user.name}', u.cardID: '${user.cardID}', u.address:'${user.address}'}) return u`)
    return result.records[0].properties
}
const findByIDAndDelete = async (id)=> {
    await session.run(`MATCH (u:User {_id: '${id}'}) DELETE u`)
    return await findAll()
}



export default {
    findAll,
    findById,
    create,
    findByIDAndUpdate,
    findByIDAndDelete
}