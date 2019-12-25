import { ADD_ITEM_TO_CART, DELETE_ITEM_FROM_CART } from './../reducers/cartReducer';

export function addItemToCart(product) {
  return function(dispatch) {
    dispatch({
      type: ADD_ITEM_TO_CART,
      data: product,
      receivedAt: Date.now()
    })
  }
}

export function deleteItemFromCart(item) {
  return function (dispatch) {
    dispatch({
      type: DELETE_ITEM_FROM_CART,
      data: item.product.id,
      receivedAt: Date.now()
    })
  }
}