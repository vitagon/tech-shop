const initState = {
  categories: [
    { id: 22, name: 'headphones', parentId: 0 },
    { id: 23, name: 'cellphones', parentId: 0 },
    { id: 24, name: 'video cards', parentId: 0 }
  ]
}

const rootReducer = (state = initState, action) => {
  return state;
}

export default rootReducer;