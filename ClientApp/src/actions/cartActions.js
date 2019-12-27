import {
  ADD_ITEM_TO_CART,
  DELETE_ITEM_FROM_CART,
  SET_RAW_ITEM_QUANTITY,
  SET_ITEM_QUANTITY,
  DECREMENT_ITEM_QUANTITY,
  INCREMENT_ITEM_QUANTITY
} from './../reducers/cartReducer';

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

export function setRawItemQuantity(item, qty) {
  return function (dispatch) {
    dispatch({
      type: SET_RAW_ITEM_QUANTITY,
      data: {
        id: item.product.id,
        qty: qty
      },
      receivedAt: Date.now()
    })
  }
}

export function setItemQuantity(item, qty) {
  return function (dispatch) {
    dispatch({
      type: SET_ITEM_QUANTITY,
      data: {
        id: item.product.id,
        qty: qty
      },
      receivedAt: Date.now()
    })
  }
}

export function decrementItemQuantity(item) {
  return function (dispatch) {
    dispatch({
      type: DECREMENT_ITEM_QUANTITY,
      data: item.product.id,
      receivedAt: Date.now()
    })
  }
}

export function incrementItemQuantity(item) {
  return function (dispatch) {
    dispatch({
      type: INCREMENT_ITEM_QUANTITY,
      data: item.product.id,
      receivedAt: Date.now()
    })
  }
}